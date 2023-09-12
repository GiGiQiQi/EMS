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
    public partial class Form2 : Form
    {
        IMongoCollection<CActiveRescuers> activeRescuers;
        IMongoCollection<CRescuers> rescuersInfo;
        IMongoCollection<CActiveEvacuees> activeEvacuues;
        private const int DelayMilliseconds = 500;
        private bool isRfidProcessed = false;

        public Form2()
        {
            InitializeComponent();
            customDesign();
            ScanTimer.Interval = DelayMilliseconds;
            ScanTimer.Tick += ScanTimer_Tick;
        }
        private void customDesign()
        {
            EvacDropDown.Visible = false;
            regMenu.Visible = false;
        }
        private void hideSideMenu()
        {
            if (EvacDropDown.Visible == true)
                EvacDropDown.Visible = false;
            if (regMenu.Visible == true)
                regMenu.Visible = false;
        }
        private void showSubMenu(Panel Dropdown)
        {
            if(Dropdown.Visible == false)
            {
                hideSideMenu();
                Dropdown.Visible = true;
            }
            else
            {
                Dropdown.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(EvacDropDown);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_Site_Form());
            hideSideMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Evacuation_Sites());
            hideSideMenu();
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
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(regMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Evacuee_Registration());
            hideSideMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FRescuer_Registration());
            hideSideMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FDashboard());
            hideSideMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FAssign());
            hideSideMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new FWarnings());
            hideSideMenu();
        }
        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            ScanTimer.Stop();

            var filter = Builders<CRescuers>.Filter.Eq(u => u.ResRFID, textBox1.Text);
            var user = rescuersInfo.Find(filter).FirstOrDefault();

            var filters = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, textBox1.Text);
            var users = activeRescuers.Find(filters).FirstOrDefault();


            if (!isRfidProcessed && textBox1.Text.Length == 10)
            {
                isRfidProcessed = true; // Move this line above the data insertion block.

                if(users != null)
                {
                    var del = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, textBox1.Text);
                    activeRescuers.DeleteOne(del);
                    MessageBox.Show("Timeout successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (user != null)
                {
                    var active = new CActiveRescuers
                    {
                        RName = user.RescuerName,
                        RescuerRFID = textBox1.Text
                    };
                    activeRescuers.InsertOne(active);
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");
            rescuersInfo = database.GetCollection<CRescuers>("RescuersInfo");
            activeEvacuues = database.GetCollection<CActiveEvacuees>("ActiveEvacuues");

            //Start of loading the counting Data feature
            var eCount = 0;
            var rCount = 0;
            
            var AEFilter = Builders<CActiveEvacuees>.Filter.Empty;
            var ARFilter = Builders<CActiveRescuers>.Filter.Empty;

            var docAEF = activeEvacuues.Find(AEFilter).ToList();
            var docARF = activeRescuers.Find(ARFilter).ToList();

            List<CActiveEvacuees> evacueeList = new List<CActiveEvacuees>();
            List<CActiveRescuers> rescuerList = new List<CActiveRescuers>();

            foreach (var Edocument in docAEF)
            {
                evacueeList.Add(Edocument);
            }
            foreach (var Rdocument in docARF)
            {
                rescuerList.Add(Rdocument);
            }

            foreach (var eData in evacueeList)
            {
                eCount = eCount + 1;
            }
            TELabel.Text = eCount.ToString();
            foreach (var rDate in rescuerList)
            {
                rCount = rCount + 1;
            }
            ACLabel.Text = rCount.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ScanTimer.Stop();
            ScanTimer.Start();

            isRfidProcessed = false;
        }
    }
}
