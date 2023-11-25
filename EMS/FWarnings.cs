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
    public partial class FWarnings : Form
    {
        IMongoCollection<CMNumbers1> mobilenumbers;
        public FWarnings()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var filter = Builders<CMNumbers1>.Filter.Empty;
            var documents = mobilenumbers.Find(filter).ToList();

            List<CMNumbers1> dataList = new List<CMNumbers1>();

            foreach (var document in documents)
            {
                dataList.Add(document);
            }

            foreach (var data in dataList)
            {
                SerialPort sp = new SerialPort();
                sp.PortName = "COM4";
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(500);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(500);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(500);
                sp.WriteLine("AT+CMGS=\"" + data.Number + "\"" + Environment.NewLine);
                Thread.Sleep(500);
                sp.WriteLine(textBox1.Text + Environment.NewLine);
                Thread.Sleep(500);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(1000);

                var response = sp.ReadExisting();

                if (response.Contains("ERROR"))
                {
                    MessageBox.Show($"Message not sent to {data.Number}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Message sent to {data.Number}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sp.Close();
            }


        }

        private void FWarnings_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            mobilenumbers = database.GetCollection<CMNumbers1>("MobileNumbers");
        }
    }
}
