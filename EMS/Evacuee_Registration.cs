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
    public partial class Evacuee_Registration : Form
    {
        IMongoCollection<CEvacuee> evacueeCollection;
        IMongoCollection<CMNumbers1> mobileNumbers;
        public Evacuee_Registration()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Evacuee_Registration_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            evacueeCollection = database.GetCollection<CEvacuee>("EvacueeInfo");
            mobileNumbers = database.GetCollection<CMNumbers1>("MobileNumbers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (RFIDTB.Texts == "" || NAMETB.Texts == "" || AddTB.Texts == "" || BrgTB.Texts == "" || CNTB.Texts == "" || DepTB.Texts == "" || CPTB.Texts == "" || CPNTB.Texts == "" || RelTB.Texts == "")
            {
                MessageBox.Show("Please fill out the necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var evacuees = new CEvacuee
                {
                    RFID_Number = RFIDTB.Texts,
                    Evacuee_Name = NAMETB.Texts,
                    Evacuee_Address = AddTB.Texts,
                    Barangay = BrgTB.Texts,
                    Contact_Number = CNTB.Texts,
                    Dependents = decimal.Parse(DepTB.Texts),
                    Contact_Person = CPTB.Texts,
                    Contact_Person_Number = CPNTB.Texts,
                    Relationship = RelTB.Texts
                };
                evacueeCollection.InsertOneAsync(evacuees);

                var numbers = new CMNumbers1
                {
                    Number = CNTB.Texts
                };
                mobileNumbers.InsertOneAsync(numbers);
                if (evacuees != null)
                {
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RFIDTB.Texts = "";
                    NAMETB.Texts = "";
                    AddTB.Texts = "";
                    BrgTB.Texts = "";
                    CNTB.Texts = "";
                    DepTB.Texts = "";
                    CPTB.Texts = "";
                    CPNTB.Texts = "";
                    RelTB.Texts = "";
                }
                else
                {
                    MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RFIDTB__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FEvacuees form28 = new FEvacuees();
            form28.Show();
        }
    }
}
