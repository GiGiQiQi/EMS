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
        IMongoCollection<CPersonnel> personnelCollection;
        public FSignUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FSignUp_Load(object sender, EventArgs e)
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
            catch (Exception)
            {
                MessageBox.Show("An error occurred Please Check Internet Connection");
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(KeyTB.Texts == "0007399431")
            {
                if (AdminRad.Checked)
                {
                    var admins = new CAdmin
                    {
                        Admin_Name = AName.Texts,
                        Address = AAddress.Texts,
                        Contact_Number = ANumber.Texts,
                        BirtDate = rjDatePicker1.Text,
                        Gender = AGender.Texts,
                        Username = AUser.Texts,
                        Password = APass.Texts
                    };
                    adminCollection.InsertOneAsync(admins);
                    if (admins != null)
                    {
                        MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AName.Texts = "";
                    AAddress.Texts = "";
                    ANumber.Texts = "";
                    AUser.Texts = "";
                    APass.Texts = "";
                    AGender.Text = "";
                }
                else if (PersonRad.Checked)
                {
                    var personnels = new CPersonnel
                    {
                        Personnel_Name = AName.Texts,
                        Personnel_Address = AAddress.Texts,
                        Personnel_CNumber = ANumber.Texts,
                        BirthDate = rjDatePicker1.Text,
                        Gender = AGender.Texts,
                        Username = AUser.Texts,
                        Password = APass.Texts
                    };
                    personnelCollection.InsertOneAsync(personnels);
                    if (personnels != null)
                    {
                        MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AName.Texts = "";
                    AAddress.Texts = "";
                    ANumber.Texts = "";
                    AUser.Texts = "";
                    APass.Texts = "";
                    AGender.Text = "";
                }
                else
                {
                    MessageBox.Show("Please select a user type");
                }
            }
            else
            {
                MessageBox.Show("Please enter the key");
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

