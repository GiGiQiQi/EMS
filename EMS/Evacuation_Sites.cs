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
            string siteone = "Montalban Gymnasium";
            string sitetwo = "Montalban Evacuation Center";
            string sitethree = "Southville 8B PH2 Annex Evacuation Center";
            string sitefour = "Sitio Tanag Covered Court";
            string siteFive = "Southville 8B PH4 covered court";
            string sitesix = "Southville 8B PH2 Covered Court";
            string siteseven = "Soutvhille 8B National Highschool Covered Court";

            var filterSiteone = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, siteone);
            var filterSitetwo = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, sitetwo);
            var filterSitethree = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, sitethree);
            var filterSitefour = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, sitefour);
            var filterSitefive = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, siteFive);
            var filterSitesix = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, sitesix);
            var filterSiteseven = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, siteseven);

            var countOne = activeEvacuees.CountDocuments(filterSiteone);
            var countTwo = activeEvacuees.CountDocuments(filterSitetwo);
            var countThree = activeEvacuees.CountDocuments(filterSitethree);
            var countFour = activeEvacuees.CountDocuments(filterSitefour);
            var countFive = activeEvacuees.CountDocuments(filterSitefive);
            var countSix = activeEvacuees.CountDocuments(filterSitesix);
            var countSeven = activeEvacuees.CountDocuments(filterSiteseven);

            string siteoneResult = string.Concat(siteone, countOne);
            string sitetwoResult = string.Concat(sitetwo, countTwo);
            string sitethreeResult = string.Concat(sitethree, countThree);
            string sitefourResult = string.Concat(sitefour, countFour);
            string sitefiveResult = string.Concat(siteFive, countFive);
            string sitesixResult = string.Concat(sitesix, countSix);
            string sitesevenResult = string.Concat(siteseven, countSeven);

            DocumentCore dc = new DocumentCore();
            dc.Content.End.Insert("Evacuation Site Status and Population " + rjDatePicker1.Text + siteoneResult + "\n" + sitetwoResult + "\n" + sitethreeResult + "\n" + sitefourResult + "\n" + sitefiveResult + "\n" + sitesixResult + "\n" + sitesevenResult, new CharacterFormat { FontName = "Arial", Size = 12f });
            dc.Save("Result.docx");

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("Result.docx") { UseShellExecute = true });

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
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filter = Builders<CActiveEvacuees>.Filter.Eq(a => a.ESite, comboBox1.Text);
            var filterDefinition = Builders<ESite>.Filter.Eq(a => a.Evacuation_name, comboBox1.Text);
            var site = sitesCollection.Find(filterDefinition).FirstOrDefault();

            var count = activeEvacuees.CountDocuments(filter);
            AELabel.Text = count.ToString();
        }
    }
}
