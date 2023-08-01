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
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
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
            evacueeCollection.InsertOne(evacuees);
            if (evacuees != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
