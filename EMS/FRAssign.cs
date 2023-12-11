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
using System.Configuration;
using System.IO.Ports;
using System.Threading;

namespace EMS
{
    public partial class FRAssign : Form
    {
        IMongoCollection<CRequests> reqsCollection;
        IMongoCollection<CATeams> activeTeams;
        public FRAssign()
        {
            InitializeComponent();
        }
        private void responsiveDesign()
        {
            if(this.Height > 50)
            {
                panel2.Height = panel1.Height;
            }
        }

        private void FRAssign_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadDatagrid()
        {
            var filterDefinition = Builders<CRequests>.Filter.Empty;
            var site = reqsCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void FRAssign_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            reqsCollection = database.GetCollection<CRequests>("requests");
            activeTeams = database.GetCollection<CATeams>("ActiveTeams");

            loadDatagrid();
            LoadComboBoxItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                AddTB.Texts = selectedRow.Cells["ReqAddress"].Value.ToString();
                MobTB.Texts = selectedRow.Cells["ReqNumber"].Value.ToString();
            }
        }
        private void LoadComboBoxItems()
        {
            var filter = Builders<CATeams>.Filter.Empty;
            var projection = Builders<CATeams>.Projection.Include("TeamNumber");

            var cursor = activeTeams.Find(filter).Project(projection).ToCursor();

            foreach (var document in cursor.ToEnumerable())
            {
                rjComboBox1.Items.Add(document["TeamNumber"].AsString);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filter = Builders<CATeams>.Filter.Eq(u => u.TNum, rjComboBox1.Texts);
            var user = activeTeams.Find(filter).FirstOrDefault();

            var confirmation = "Your request Have been received, rescue will be sent immediately.";
            var confirmation2 = "Your Assignment is to rescue an Evacuue at" + AddTB.Texts;

            SerialPort sp = new SerialPort();
            sp.PortName = "COM8";
            sp.Open();
            sp.WriteLine("AT" + Environment.NewLine);
            Thread.Sleep(500);
            sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
            Thread.Sleep(500);
            sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
            Thread.Sleep(500);
            sp.WriteLine("AT+CMGS=\"" + MobTB.Texts + "\"" + Environment.NewLine);
            Thread.Sleep(500);
            sp.WriteLine(confirmation + Environment.NewLine);
            Thread.Sleep(500);
            sp.Write(new byte[] { 26 }, 0, 1);
            Thread.Sleep(3000);

            var response = sp.ReadExisting();
            sp.Close();

            SerialPort sp1 = new SerialPort();
            sp1.PortName = "COM8";
            sp1.Open();
            sp1.WriteLine("AT" + Environment.NewLine);
            Thread.Sleep(500);
            sp1.WriteLine("AT+CMGF=1" + Environment.NewLine);
            Thread.Sleep(500);
            sp1.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
            Thread.Sleep(500);
            sp1.WriteLine("AT+CMGS=\"" + user.TeamContact + "\"" + Environment.NewLine);
            Thread.Sleep(500);
            sp1.WriteLine(confirmation2 + Environment.NewLine);
            Thread.Sleep(500);
            sp1.Write(new byte[] { 26 }, 0, 1);
            Thread.Sleep(500);

            var response1 = sp1.ReadExisting();

            if(response.Contains("Error") && response1.Contains("Error"))
            {
                MessageBox.Show("Message not sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Message sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sp1.Close();
        }
    }
}
