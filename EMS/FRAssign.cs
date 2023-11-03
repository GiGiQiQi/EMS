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

            loadDatagrid();
        }
    }
}
