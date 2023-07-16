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
    public partial class FSignUp : Form
    {
        IMongoCollection<CAdmin> adminCollection;
        public FSignUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var admins = new CAdmin
            {
                Admin_Name = AName.Text,
                Address = AAddress.Text,
                Contact_Number = ANumber.Text,
                BirtDate = dateTimePicker1.Text,
                Gender = AGender.Text,
                Username = AUser.Text,
                Password = APass.Text
            };
            adminCollection.InsertOne(admins);
            if (admins != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AName.Clear();
            AAddress.Clear();
            ANumber.Clear();
            AUser.Clear();
            APass.Clear();
            AGender.Text = "";
        }

        private void FSignUp_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            adminCollection = database.GetCollection<CAdmin>("AdminInfo");
        }
    }
}
