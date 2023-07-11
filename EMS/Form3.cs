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
    public partial class Add_Site_Form : Form
    {
        IMongoCollection<ESite> sitesCollection;
        public Add_Site_Form()
        {
            InitializeComponent();
        }

        private void Add_Site_Form_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            sitesCollection = database.GetCollection<ESite>("EvacuationSites");

            LoadDataGrid();
        }

        private void BADD_Click(object sender, EventArgs e)
        {
            var sites = new ESite
            {
                Evacuation_name = ENAME.Text,
                Est_type = ETYPE.Text,
                Address = EADD.Text,
                Capacity = ECAP.Text
            };

            LoadDataGrid();
            sitesCollection.InsertOne(sites);
            if (sites != null)
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
            var filterDefinition = Builders<ESite>.Filter.Empty;
            var site = sitesCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
    }
}
