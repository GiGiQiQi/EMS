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
    public partial class FUserDashboard : Form
    {
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        IMongoCollection<CEvacuee> evacueeCollection;
        private const int DelayMilliseconds = 5;
        private bool isRfidProcessed = false;

        public FUserDashboard()
        {
            InitializeComponent();

            timer1.Interval = DelayMilliseconds;
            timer1.Tick += timer1_Tick;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FEvacTI());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Evacuation_Sites());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

            isRfidProcessed = false;
        }

        private void FUserDashboard_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuees");
            evacueeCollection = database.GetCollection<CEvacuee>("EvacueeInfo");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            var filter = Builders<CEvacuee>.Filter.Eq(u => u.RFID_Number, textBox1.Text);
            var user = evacueeCollection.Find(filter).FirstOrDefault();

            if (!isRfidProcessed && textBox1.Text.Length == 10)
            {
                isRfidProcessed = true; // Move this line above the data insertion block.

                if (user != null)
                {
                    var active = new CActiveEvacuees
                    {
                        EName = user.Evacuee_Name,
                        EAddress = user.Evacuee_Address,
                        CPerson = user.Contact_Person_Number,
                        ESite = comboBox1.Text,
                        DPS = user.Dependents
                    };
                    activeEvacuues.InsertOne(active);
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FEvacueeTI());
        }
    }
}
