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
    public partial class FEvacTI : Form
    {
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        IMongoCollection<CEvacuee> evacueeCollection;
        IMongoCollection<CEHistory> evacuationHistory;
        private const int DelayMilliseconds = 500;
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
                    evacuationHistory.InsertOne(archive);

                    var del = Builders<CActiveEvacuees>.Filter.Eq(u => u.RFID, SCANTB.Text);
                    activeEvacuues.DeleteOne(del);
                    MessageBox.Show("Timeout successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (user != null)
                {
                    var active = new CActiveEvacuees
                    {
                        RFID = SCANTB.Text,
                        EName = user.Evacuee_Name,
                        EAddress = user.Evacuee_Address,
                        CPerson = user.Contact_Person_Number,
                        ESite = ESITETB.Text,
                        DPS = user.Dependents,
                        Date = dateTimePicker1.Text
                    };
                    activeEvacuues.InsertOne(active);
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
