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
        IMongoCollection<CPersonnel> personnelCollection;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                adminCollection = database.GetCollection<CAdmin>("AdminInfo");
                personnelCollection = database.GetCollection<CPersonnel>("PersonnelInfo");
            }
            catch (MongoConnectionException ex)
            {
                MessageBox.Show("MongoDB Connection error: " + ex.Message);
            }
            catch (MongoCommandException ex)
            {
                MessageBox.Show("MongoDB Command error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = rjTextBox1.Texts;
                string password = rjTextBox2.Texts;

                if (AdminRad.Checked)
                {
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
                else if (PersonnelRad.Checked)
                {
                    var filters = Builders<CPersonnel>.Filter.Eq(u => u.Username, username) & Builders<CPersonnel>.Filter.Eq(u => u.Password, password);
                    var user = personnelCollection.Find(filters).FirstOrDefault();

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
                else
                {
                    MessageBox.Show("Please select a User Type");
                }
            }
            catch (MongoConnectionException ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
            catch(MongoCommandException ex)
            {
                MessageBox.Show("Command error: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }
        }

            private void rjButton2_Click(object sender, EventArgs e)
            {
                this.Hide();
                FSignUp form9 = new FSignUp();
                form9.Show();
            }
        }
    }
