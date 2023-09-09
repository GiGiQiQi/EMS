using MongoDB.Driver;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace EMS
{
    public partial class FEvacueeTI : Form
    {
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        public FEvacueeTI()
        {
            InitializeComponent();
        }

        private void FEvacueeTI_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");

            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            var filterDefinition = Builders<CActiveEvacuees>.Filter.Empty;
            var site = activeEvacuues.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var active = new CActiveEvacuees
            {
                RFID = "No RFID",
                EName = NameTB.Texts,
                EAddress = AddTB.Texts,
                CPerson = ConTB.Texts,
                ESite = ETB.Texts,
                DPS = decimal.Parse(DPTB.Texts),
                Date = rjDatePicker1.Text
            };
            LoadDataGrid();
            activeEvacuues.InsertOne(active);
            LoadDataGrid();
            if (active != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<CActiveEvacuees>.Filter.Or(
                Builders<CActiveEvacuees>.Filter.Eq(a => a.EName, searchTB.Texts),
                Builders<CActiveEvacuees>.Filter.Eq(a => a.EAddress, searchTB.Texts),
                Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, searchTB.Texts)
                );
            var families = activeEvacuues.Find(filterDefinition).ToList();
            dataGridView1.DataSource = families;
        }
    }
}
