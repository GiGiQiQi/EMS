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
using SautinSoft.Document;

namespace EMS
{
    public partial class Evacuation_Sites : Form
    {
        IMongoCollection<ESite> sitesCollection;
        IMongoCollection<CActiveEvacuees> activeEvacuees;
        public Evacuation_Sites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FHistory form7 = new FHistory();
            form7.Show();
        }
        private void LoadComboBoxItems()
        {
            var filter = Builders<ESite>.Filter.Empty;
            var projection = Builders<ESite>.Projection.Include("Site_Name");

            var cursor = sitesCollection.Find(filter).Project(projection).ToCursor();

            foreach (var document in cursor.ToEnumerable())
            {
                comboBox1.Items.Add(document["Site_Name"].AsString);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Evacuation_Sites_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                sitesCollection = database.GetCollection<ESite>("EvacuationSites");
                activeEvacuees = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
            }
            catch (MongoConnectionException ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
            catch (MongoCommandException ex)
            {
                MessageBox.Show("Command error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }
            LoadComboBoxItems();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filter = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, comboBox1.Text);
            var filterDefinition = Builders<ESite>.Filter.Eq(a => a.Evacuation_name, comboBox1.Text);
            var site = sitesCollection.Find(filterDefinition).FirstOrDefault();

            var count = activeEvacuees.CountDocuments(filter);

            CapLabel.Text = site.Capacity;
            AELabel.Text = count.ToString();
        }
    }
}
