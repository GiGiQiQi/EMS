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
    public partial class FActiveRescuers : Form
    {
        IMongoCollection<CActiveRescuers> activeRescuers;
        public FActiveRescuers()
        {
            InitializeComponent();
        }

        private void FActiveRescuers_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");
        }
        private void loadDataGrid()
        {
            var filterDefinition = Builders<CActiveRescuers>.Filter.Empty;
            var site = activeRescuers.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
    }
}
