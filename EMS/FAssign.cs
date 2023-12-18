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
using System.IO.Ports;
using System.Threading;


namespace EMS
{
    public partial class FAssign : Form
    {
        IMongoCollection<CActiveRescuers> activeRescuers;
        IMongoCollection<CATeams> activeTeams;
        IMongoCollection<CRescuers> rescuersInfo;
        public FAssign()
        {
            InitializeComponent();
        }

        private void FAssign_Load(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");
                activeTeams = database.GetCollection<CATeams>("ActiveTeams");
                rescuersInfo = database.GetCollection<CRescuers>("RescuersInfo");
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
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            var filterDefinition = Builders<CActiveRescuers>.Filter.Empty;
            var site = activeRescuers.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }
        private void loadDataGrid2()
        {
            var filterDefinition = Builders<CATeams>.Filter.Empty;
            var site = activeTeams.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rjRadioButton1.Checked)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    if (RIDTB.Texts == "")
                    {

                        RIDTB.Texts = selectedRow.Cells["RescuerRFID"].Value.ToString();
                    }
                    else if (RFIDTB1.Texts == "")
                    {
                        RFIDTB1.Texts = selectedRow.Cells["RescuerRFID"].Value.ToString();
                    }
                    else if (RFIDTB2.Texts == "")
                    {
                        RFIDTB2.Texts = selectedRow.Cells["RescuerRFID"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Pleas Remove One of the filled Textbox for Rescruer  RfID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FActiveRescuers form1 = new FActiveRescuers();
            form1.Show();
        }
        private void responsiveDesign()
        {
            if(this.Height > 50)
            {
                panel2.Height = panel1.Height;
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            responsiveDesign();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task<bool> CheckTeamExistence(string teamName)
        {
            var filter = Builders<CATeams>.Filter.Eq("TeamName", teamName);
            var count = await activeTeams.CountDocumentsAsync(filter);
            return count > 0;
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            if (rjRadioButton1.Checked)
            {
                var firstRescuer = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, RIDTB.Texts);
                var secondRescuer = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, RFIDTB1.Texts);
                var thirdRescuer = Builders<CActiveRescuers>.Filter.Eq(u => u.RescuerRFID, RFIDTB2.Texts);
                var filter = Builders<CRescuers>.Filter.Eq(u => u.ResRFID, RIDTB.Texts);
                var rescuer = rescuersInfo.Find(filter).FirstOrDefault();

                var confirmation2 = "Your Are now assigned to team" + TNCB.Texts;

                var teamName = TNCB.Texts;

                if (await CheckTeamExistence(teamName))
                {
                    MessageBox.Show("Team already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var Teams = new CATeams
                    {
                        MemberName = new List<string>
                    {
                        RIDTB.Texts,
                        RFIDTB1.Texts,
                        RFIDTB2.Texts
                    },
                        TeamName = teamName,
                        TeamContact = rescuer.Contact_Number
                    };
                    await activeTeams.InsertOneAsync(Teams);
                    SerialPort sp1 = new SerialPort();
                    sp1.PortName = "COM8";
                    sp1.Open();
                    sp1.WriteLine("AT" + Environment.NewLine);
                    Thread.Sleep(500);
                    sp1.WriteLine("AT+CMGF=1" + Environment.NewLine);
                    Thread.Sleep(500);
                    sp1.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                    Thread.Sleep(500);
                    sp1.WriteLine("AT+CMGS=\"" + rescuer.Contact_Number + "\"" + Environment.NewLine);
                    Thread.Sleep(500);
                    sp1.WriteLine(confirmation2 + Environment.NewLine);
                    Thread.Sleep(500);
                    sp1.Write(new byte[] { 26 }, 0, 1);
                    Thread.Sleep(500);

                    var response1 = sp1.ReadExisting();

                    if (response1.Contains("Error"))
                    {
                        MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sp1.Close();
                    var firstDel = activeRescuers.DeleteOneAsync(firstRescuer);
                    var secondDel = activeRescuers.DeleteOneAsync(secondRescuer);
                    var thirdDel = activeRescuers.DeleteOneAsync(thirdRescuer);
                }
            }
            else if (rjRadioButton2.Checked)
            {
                var filter = Builders<CATeams>.Filter.Eq(u => u.TeamName, TNCB.Texts);
                var teamDel = activeTeams.DeleteOneAsync(filter);

                loadDataGrid2();
            }
            else
            {
                MessageBox.Show("Please Select an Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGrid2();
            RIDTB.Texts = "";
            RFIDTB1.Texts = "";
            RFIDTB2.Texts = "";
            rjButton1.Text = "Remove";
            TNCB.Texts = "";
        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            loadDataGrid();
            RIDTB.Texts = "";
            RFIDTB1.Texts = "";
            RFIDTB2.Texts = "";
            rjButton1.Text = "Assign";
            TNCB.Texts = "";
        }
    }
}
