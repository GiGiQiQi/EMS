using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace EMS
{
    public partial class FRescuer_Registration : Form
    {
        IMongoCollection<CRescuers> rescuersCollection;
        public FRescuer_Registration()
        {
            InitializeComponent();
        }

        private void FRescuer_Registration_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            rescuersCollection = database.GetCollection<CRescuers>("RescuersInfo");

            LoadDataGrid();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            var rescuers = new CRescuers
            {
                RescuerName = RName.Text,
                Address = RAddress.Text,
                BirtDate = dateTimePicker1.Text,
                Gender = RGender.Text,
                Contact_Number = RName.Text
            };
            LoadDataGrid();
            rescuersCollection.InsertOne(rescuers);
            if (rescuers != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataGrid()
        {
            var filterDefinition = Builders<CRescuers>.Filter.Empty;
            var site = rescuersCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
    }
}
