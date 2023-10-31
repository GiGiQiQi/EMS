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
        }
        private void LoadDataGrid()
        {
            var filterDefinition = Builders<ESite>.Filter.Empty;
            var site = sitesCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var sites = new ESite
            {
                Site_ID = SiteID.Texts,
                Evacuation_name = ENAME.Texts,
                Est_type = ETYPE.Texts,
                Address = EADD.Texts,
                Capacity = ECAP.Texts
            };

            LoadDataGrid();
            sitesCollection.InsertOneAsync(sites);
            if (sites != null)
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
            var filterDefinition = Builders<ESite>.Filter.Eq(a => a.Site_ID, SiteID.Texts);
            var updateDefinition = Builders<ESite>.Update
                .Set(a => a.Evacuation_name, ENAME.Texts)
                .Set(a => a.Address, EADD.Texts)
                .Set(a => a.Capacity, ECAP.Texts)
                .Set(a => a.Est_type, ETYPE.Texts);

            sitesCollection.UpdateOneAsync(filterDefinition, updateDefinition);
            LoadDataGrid();
            if (updateDefinition != null)
            {
                MessageBox.Show("Record Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record Updated unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                SiteID.Texts = selectedRow.Cells["Site_ID"].Value.ToString();
                ENAME.Texts = selectedRow.Cells["Evacuation_name"].Value.ToString();
                EADD.Texts = selectedRow.Cells["Address"].Value.ToString();
                ECAP.Texts = selectedRow.Cells["Capacity"].Value.ToString();
                ETYPE.Texts = selectedRow.Cells["Est_Type"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<ESite>.Filter.Eq(a => a.Site_ID, SiteID.Texts);
            var site = sitesCollection.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
        private void responsiveDesign()
        {
            if(this.Height > 50)
            {
                panel2.Height = panel1.Height;
            }
        }

        private void Add_Site_Form_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
        }
    }
}
