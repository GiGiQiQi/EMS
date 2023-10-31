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
            var msgIN = "Time in";
            var msgOUT = "Time out";

            var filter = Builders<CEvacuee>.Filter.Eq(u => u.RFID_Number, SCANTB.Text);
            var user = evacueeCollection.Find(filter).FirstOrDefault();

            var filters = Builders<CActiveEvacuees>.Filter.Eq(u => u.RFID, SCANTB.Text);
            var users = activeEvacuues.Find(filters).FirstOrDefault();

            if (!isRfidProcessed && SCANTB.Text.Length == 10)
            {
                isRfidProcessed = true; // Move this line above the data insertion block.

                if(users != null)
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
                    sp.PortName = "COM8";
                    sp.Open();
                    sp.WriteLine("AT" + Environment.NewLine);
                    Thread.Sleep(200);
                    sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                    Thread.Sleep(200);
                    sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                    Thread.Sleep(200);
                    sp.WriteLine("AT+CMGS=\"" + user.Contact_Person_Number + "\"" + Environment.NewLine);
                    Thread.Sleep(200);
                    sp.WriteLine(msgOUT + Environment.NewLine);
                    Thread.Sleep(200);
                    sp.Write(new byte[] { 26 }, 0, 1);
                    Thread.Sleep(200);
                    var response = sp.ReadExisting();
                    if (response.Contains("ERROR"))
                    {
                        MessageBox.Show("Message not sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Timeout successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Date = dateTimePicker1.Text
                    };
                    activeEvacuues.InsertOneAsync(active);
                    SerialPort sp = new SerialPort();
                    sp.PortName = "COM8";
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
                        MessageBox.Show("Message not sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sp.Close();
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
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
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
            evacueeCollection = database.GetCollection<CEvacuee>("EvacueeInfo");
            evacuationHistory = database.GetCollection<CEHistory>("EvacuationHistory");
            sitesCollection = database.GetCollection<ESite>("EvacuationSites");

            LoadComboBoxItems();
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
            var filterDefinition = Builders<CActiveEvacuees>.Filter.Empty;
            var site = activeEvacuues.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
        private void responsiveDesign()
        {
            if (this.Height > 50)
            {
                panel3.Height = panel2.Height;
            }
        }

        private void FEvacTI_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
