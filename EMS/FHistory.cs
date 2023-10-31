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
    public partial class FHistory : Form
    {
        IMongoCollection<CEHistory> evacHistory;
        public FHistory()
        {
            InitializeComponent();
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            evacHistory = database.GetCollection<CEHistory>("EvacuationHistory");

            LoadDataGrid();
            var EFilter = Builders<CEHistory>.Filter.Empty;
            long eCount = evacHistory.CountDocuments(EFilter);

            ELabel.Text = eCount.ToString();
        }
        private void LoadDataGrid()
        {
            var filterDefinition = Builders<CEHistory>.Filter.Empty;
            var site = evacHistory.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<CEHistory>.Filter.Or(
                Builders<CEHistory>.Filter.Eq(a => a.EvacueeName, searchTB.Texts),
                Builders<CEHistory>.Filter.Eq(a => a.EvacueeAddress, searchTB.Texts),
                Builders<CEHistory>.Filter.Eq(a => a.EvacSite, searchTB.Texts)
                );
            var infos = evacHistory.Find(filterDefinition).ToList();
            dataGridView1.DataSource = infos;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void responsiveDesign()
        {
            if (this.Height > 50)
            {
                panel3.Height = panel2.Height;
            }
        }

        private void FHistory_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
