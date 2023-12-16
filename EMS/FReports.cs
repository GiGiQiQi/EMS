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
    public partial class FReports : Form
    {
        IMongoCollection<CActiveEvacuees> activeEvacuees;
        public FReports()
        {
            InitializeComponent();
        }

        private void FReports_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                activeEvacuees = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
            }
            catch (MongoConnectionException ex)
            {
                MessageBox.Show("MongoDB Connection error: " + ex.Message);
            }
            catch (MongoCommandException ex)
            {
                MessageBox.Show("MongoDB Command error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentCore dc = new DocumentCore();
            dc.Content.End.Insert("Hello World", new CharacterFormat { FontName = "Arial", Size = 12f });
            dc.Save("Result.docx");

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("Result.docx") { UseShellExecute = true });
        }
    }
}
