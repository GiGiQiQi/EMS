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
    public partial class FEvacuees : Form
    {
        IMongoCollection<CEvacuee> evacueeCollection;
        public FEvacuees()
        {
            InitializeComponent();
        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void FEvacuees_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            evacueeCollection = database.GetCollection<CEvacuee>("EvacueeInfo");
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            var filterDefinition = Builders<CEvacuee>.Filter.Empty;
            var site = evacueeCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<CEvacuee>.Filter.Eq(a => a.RFID_Number, SearchTB.Texts);
            var updateDefinition = Builders<CEvacuee>.Update
                .Set(a => a.Evacuee_Name, NameTB.Texts)
                .Set(a => a.Evacuee_Address, AddTB.Texts)
                .Set(a => a.Barangay, BrgTB.Texts)
                .Set(a => a.Contact_Number, ContTB.Texts)
                .Set(a => a.Contact_Person, ContPerTB.Texts)
                .Set(a => a.Contact_Person_Number, ContNumTB.Texts)
                .Set(a => a.Relationship, RelTB.Texts);

            evacueeCollection.UpdateOneAsync(filterDefinition, updateDefinition);
            LoadDataGrid();

            if (updateDefinition != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<CEvacuee>.Filter.Eq(a => a.RFID_Number, SearchTB.Texts);
            var families = evacueeCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = families;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                NameTB.Texts = selectedRow.Cells["Evacuee_Name"].Value.ToString();
                AddTB.Texts = selectedRow.Cells["Evacuee_Address"].Value.ToString();
                BrgTB.Texts = selectedRow.Cells["Barangay"].Value.ToString();
                ContTB.Texts = selectedRow.Cells["Contact_Number"].Value.ToString();
                DepTB.Texts = selectedRow.Cells["Dependents"].Value.ToString();
                ContPerTB.Texts = selectedRow.Cells["Contact_Person"].Value.ToString();
                ContNumTB.Texts = selectedRow.Cells["Contact_Person_Number"].Value.ToString();
                RelTB.Texts = selectedRow.Cells["Relationship"].Value.ToString();
            }
        }
    }
}
