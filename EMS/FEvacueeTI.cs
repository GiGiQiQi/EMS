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
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
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
        private void LoadDataGrid()
        {
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
            activeEvacuues.InsertOneAsync(active);
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
        }
        private void responsiveDesign()
        {
        }

        private void FEvacueeTI_Resize(object sender, EventArgs e)
        {
        }
    }
}
