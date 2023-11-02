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
    public partial class FAssign : Form
    {
        IMongoCollection<CRequests> requests;
        IMongoCollection<CActiveRescuers> activeRescuers;
        public FAssign()
        {
            InitializeComponent();
        }

        private void FAssign_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            requests = database.GetCollection<CRequests>("requests");
            activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");

            loadDataGrid();
        }

        private void loadDataGrid()
        {
            var filterDefinition = Builders<CActiveRescuers>.Filter.Empty;
            var site = activeRescuers.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                RIDTB.Texts = selectedRow.Cells["RescuerRFID"].Value.ToString();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FActiveRescuers form1 = new FActiveRescuers();
            form1.Show();
        }
        private void responsiveDesign()
        {
            if(this.Height > 50)
            {
                panel2.Height = panel1.Height;
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
