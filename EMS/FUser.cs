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
    public partial class FUser : Form
    {
        IMongoCollection<CPersonnel> personnelCollection;
        public FUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var filter = Builders<CPersonnel>.Filter.Eq(u => u.Username, username) & Builders<CPersonnel>.Filter.Eq(u => u.Password, password);
            var user = personnelCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                FUserDashboard form22 = new FUserDashboard();
                form22.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUserSignup form20 = new FUserSignup();
            form20.Show();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            personnelCollection = database.GetCollection<CPersonnel>("PersonnelInfo");
        }
    }
}
