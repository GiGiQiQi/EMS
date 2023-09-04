using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customDesign();
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
    }
}
