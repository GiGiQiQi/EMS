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

namespace EMS
{
    public partial class FDashboard : Form
    {
        IMongoCollection<CActiveRescuers> activeRescuers;
        IMongoCollection<CRescuers> rescuersInfo;
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        IMongoCollection<CRequests> requestCollection;
        private const int DelayMilliseconds = 500;
        private bool isRfidProcessed = false;

        public FDashboard()
        {
            InitializeComponent();
            ScanTimer.Interval = DelayMilliseconds;
            ScanTimer.Tick += ScanTimer_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");
            rescuersInfo = database.GetCollection<CRescuers>("RescuersInfo");
            activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
            requestCollection = database.GetCollection<CRequests>("requests");

            var AEFilter = Builders<CActiveEvacuees>.Filter.Empty;
            long eCount = activeEvacuues.CountDocuments(AEFilter);

            var ARFilter = Builders<CActiveRescuers>.Filter.Empty;
            long rCount = activeRescuers.CountDocuments(ARFilter);

            var RFilter = Builders<CRequests>.Filter.Empty;
            long rqCount = requestCollection.CountDocuments(RFilter);

            TELabel.Text = eCount.ToString();
            ACLabel.Text = rCount.ToString();
            RLabel.Text = rqCount.ToString();
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            ScanTimer.Stop();

            var filter = Builders<CRescuers>.Filter.Eq(u => u.ResRFID, textBox1.Text);
            var user = rescuersInfo.Find(filter).FirstOrDefault();

            var filters = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, textBox1.Text);
            var users = activeRescuers.Find(filters).FirstOrDefault();


            if (!isRfidProcessed && textBox1.Text.Length == 10)
            {
                isRfidProcessed = true; // Move this line above the data insertion block.

                if (users != null)
                {
                    var del = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, textBox1.Text);
                    activeRescuers.DeleteOne(del);
                    MessageBox.Show("Timeout successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (user != null)
                {
                    var active = new CActiveRescuers
                    {
                        RName = user.RescuerName,
                        RescuerRFID = textBox1.Text
                    };
                    activeRescuers.InsertOneAsync(active);
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ScanTimer.Stop();
            ScanTimer.Start();

            isRfidProcessed = false;
        }
    }
}
