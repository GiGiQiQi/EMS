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
    public partial class Form1 : Form
    {
        IMongoCollection<CAdmin> adminCollection;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string username = UserTB.Text;
            string password = PassTB.Text;

            var filter = Builders<CAdmin>.Filter.Eq(u => u.Username, username) & Builders<CAdmin>.Filter.Eq(u => u.Password, password);
            var user = adminCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp form9 = new FSignUp();
            form9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUser Form10 = new FUser();
            Form10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            adminCollection = database.GetCollection<CAdmin>("AdminInfo");
        }
    }
}
