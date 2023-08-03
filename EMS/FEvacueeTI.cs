using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;

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
    }
}
