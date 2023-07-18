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
    public partial class FUserSignup : Form
    {
        IMongoCollection<CPersonnel> personnelCollection;
        public FUserSignup()
        {
            InitializeComponent();
        }

        private void FUserSignup_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            personnelCollection = database.GetCollection<CPersonnel>("PersonnelInfo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var personnels = new CPersonnel
            {
                Personnel_Name = NameTB.Text,
                Personnel_Address = AddTB.Text,
                Personnel_CNumber = ConTB.Text,
                BirthDate = dateTimePicker1.Text,
                Gender = GenCB.Text,
                Username = userTB.Text,
                Password = passTB.Text
            };

            personnelCollection.InsertOne(personnels);
            if (personnels != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUser form21 = new FUser();
            form21.Show();
        }
    }
}
