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
using System.Configuration;

namespace EMS
{
    public partial class FRAssign : Form
    {
        IMongoCollection<CRequests> reqsCollection;
        IMongoCollection<CATeams> activeTeams;
        public FRAssign()
        {
            InitializeComponent();
        }
        private void responsiveDesign()
        {
            if(this.Height > 50)
            {
                panel2.Height = panel1.Height;
            }
        }

        private void FRAssign_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadDatagrid()
        {
            var filterDefinition = Builders<CRequests>.Filter.Empty;
            var site = reqsCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void FRAssign_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            reqsCollection = database.GetCollection<CRequests>("requests");
            activeTeams = database.GetCollection<CATeams>("ActiveTeams");

            loadDatagrid();
            LoadComboBoxItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                AddTB.Texts = selectedRow.Cells["ReqAddress"].Value.ToString();
                MobTB.Texts = selectedRow.Cells["ReqNumber"].Value.ToString();
            }
        }
        private void LoadComboBoxItems()
        {
            var filter = Builders<CATeams>.Filter.Empty;
            var projection = Builders<CATeams>.Projection.Include("TeamNumber");

            var cursor = activeTeams.Find(filter).Project(projection).ToCursor();

            foreach (var document in cursor.ToEnumerable())
            {
                rjComboBox1.Items.Add(document["TeamNumber"].AsString);
            }
        }
    }
}
