using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using System.IO.Ports;
using System.Threading;

namespace EMS
{
    public partial class FEvacTI : Form
    {
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        IMongoCollection<CEvacuee> evacueeCollection;
        IMongoCollection<CEHistory> evacuationHistory;
        IMongoCollection<ESite> sitesCollection;
        private const int DelayMilliseconds = 20;
        private bool isRfidProcessed = false;


        public FEvacTI()
        {
            InitializeComponent();
            timer1.Interval = DelayMilliseconds;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            var filter = Builders<CEvacuee>.Filter.Eq(u => u.RFID_Number, SCANTB.Text);
            var user = evacueeCollection.Find(filter).FirstOrDefault();

            var filters = Builders<CActiveEvacuees>.Filter.Eq(u => u.RFID, SCANTB.Text);
            var users = activeEvacuues.Find(filters).FirstOrDefault();
            if(user != null) {
            string evacName = user.Evacuee_Name;
            string dateIn = dateTimePicker1.Text;

            var msgIN = "Good day, this message is sent to inform you that " + evacName + "Have successfully evacuated at" +comboBox1.Text+ " " + dateIn;
            var msgOut = "Good day, this message is sent to inform you that " + evacName + "Have exited at" + comboBox1.Text + " " + dateIn;

                if (!isRfidProcessed && SCANTB.Text.Length == 10)
                {
                    SCANTB.Enabled = false;
                    isRfidProcessed = true;

                    if (users != null)
                    {
                        var archive = new CEHistory
                        {
                            EvacueeName = users.EName,
                            EvacueeAddress = users.EAddress,
                            EvacSite = users.ESite,
                            Dependents = users.DPS,
                            dateIn = users.Date,
                            dateOut = dateTimePicker1.Text
                        };
                        evacuationHistory.InsertOneAsync(archive);
                        SerialPort sp = new SerialPort();
                        sp.PortName = textBox1.Text;
                        sp.Open();
                        sp.WriteLine("AT" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CMGS=\"" + user.Contact_Person_Number + "\"" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine(msgOut + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.Write(new byte[] { 26 }, 0, 1);
                        Thread.Sleep(200);
                        var response = sp.ReadExisting();
                        if (response.Contains("ERROR"))
                        {
                            DialogResult result = MessageBox.Show("Message not sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                SCANTB.Enabled = true;
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Timeout successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                SCANTB.Enabled = true;
                            }
                        }
                        sp.Close();
                        var del = Builders<CActiveEvacuees>.Filter.Eq(u => u.RFID, SCANTB.Text);
                        activeEvacuues.DeleteOneAsync(del);
                    }
                    else if (user != null)
                    {
                        var active = new CActiveEvacuees
                        {
                            RFID = SCANTB.Text,
                            EName = user.Evacuee_Name,
                            EAddress = user.Evacuee_Address,
                            CPerson = user.Contact_Person_Number,
                            DPS = user.Dependents,
                            Date = dateTimePicker1.Text,
                            ESite = comboBox1.Text
                        };
                        activeEvacuues.InsertOneAsync(active);
                        SerialPort sp = new SerialPort();
                        sp.PortName = textBox1.Text;
                        sp.Open();
                        sp.WriteLine("AT" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine("AT+CMGS=\"" + user.Contact_Person_Number + "\"" + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.WriteLine(msgIN + Environment.NewLine);
                        Thread.Sleep(200);
                        sp.Write(new byte[] { 26 }, 0, 1);
                        Thread.Sleep(200);
                        var response = sp.ReadExisting();
                        if (response.Contains("ERROR"))
                        {
                            DialogResult result = MessageBox.Show("Message not sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                SCANTB.Enabled = true;
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                SCANTB.Enabled = true;
                            }
                        }
                        sp.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Record not found!");
                SCANTB.Text = "";
            }
        }

        private void SCANTB_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

            isRfidProcessed = false;
        }

        private void FEvacTI_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
                evacueeCollection = database.GetCollection<CEvacuee>("EvacueeInfo");
                evacuationHistory = database.GetCollection<CEHistory>("EvacuationHistory");
                sitesCollection = database.GetCollection<ESite>("EvacuationSites");
            }
            catch (MongoConnectionException ex)
            {
                MessageBox.Show("MongoDB Connection error: " + ex.Message);
            }
            catch (MongoCommandException ex)
            {
                MessageBox.Show("MongoDB Command error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }

            LoadDataGrid();

            var AEFilter = Builders<CActiveEvacuees>.Filter.Empty;
            long eCount = activeEvacuues.CountDocuments(AEFilter);

            AELabel.Text = eCount.ToString();
        }

        private void LoadComboBoxItems()
        {
            var filter = Builders<ESite>.Filter.Empty;
            var projection = Builders<ESite>.Projection.Include("Site_Name");

            var cursor = sitesCollection.Find(filter).Project(projection).ToCursor();

            foreach (var document in cursor.ToEnumerable())
            {
                comboBox1.Items.Add(document["Site_Name"].AsString);
            }
        }

        private void LoadDataGrid()
        {
        }
        private void responsiveDesign()
        {
        }

        private void FEvacTI_Resize(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
