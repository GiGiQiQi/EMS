﻿using System;
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
    public partial class FAssign : Form
    {
        IMongoCollection<CActiveRescuers> activeRescuers;
        IMongoCollection<CATeams> activeTeams;
        public FAssign()
        {
            InitializeComponent();
        }

        private void FAssign_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            activeRescuers = database.GetCollection<CActiveRescuers>("ActiveRescuers");
            activeTeams = database.GetCollection<CATeams>("ActiveTeams");

            loadDataGrid();
        }

        private void loadDataGrid()
        {
            var filterDefinition = Builders<CActiveRescuers>.Filter.Empty;
            var site = activeRescuers.Find(filterDefinition).ToList();
            dataGridView1.DataSource = site;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (RIDTB.Texts == "")
                {

                    RIDTB.Texts = selectedRow.Cells["RescuerRFID"].Value.ToString();
                }
                else if(RFIDTB1.Texts == "")
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var Teams = new CATeams
            {
                MemberName = new List<string>
                {
                    RIDTB.Texts,
                    RFIDTB1.Texts,
                    RFIDTB2.Texts
                },
                TNum = TNCB.Texts,
                TLoc = LocTB.Texts
            };
            activeTeams.InsertOneAsync(Teams);
            if (Teams != null)
            {
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record save unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
