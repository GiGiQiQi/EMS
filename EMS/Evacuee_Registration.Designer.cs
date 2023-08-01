
using System;

namespace EMS
{
    partial class Evacuee_Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.RFIDTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.NAMETB = new RJCodeAdvance.RJControls.RJTextBox();
            this.AddTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.BrgTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.CNTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.DepTB = new RJCodeAdvance.RJControls.RJComboBox();
            this.CPTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.CPNTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.RelTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RFIDTB
            // 
            this.RFIDTB.BackColor = System.Drawing.SystemColors.Window;
            this.RFIDTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RFIDTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RFIDTB.BorderRadius = 15;
            this.RFIDTB.BorderSize = 2;
            this.RFIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RFIDTB.Location = new System.Drawing.Point(96, 68);
            this.RFIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.RFIDTB.Multiline = true;
            this.RFIDTB.Name = "RFIDTB";
            this.RFIDTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RFIDTB.PasswordChar = false;
            this.RFIDTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RFIDTB.PlaceholderText = "RFID";
            this.RFIDTB.Size = new System.Drawing.Size(250, 31);
            this.RFIDTB.TabIndex = 18;
            this.RFIDTB.Texts = "";
            this.RFIDTB.UnderlinedStyle = false;
            // 
            // NAMETB
            // 
            this.NAMETB.BackColor = System.Drawing.SystemColors.Window;
            this.NAMETB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.NAMETB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NAMETB.BorderRadius = 15;
            this.NAMETB.BorderSize = 2;
            this.NAMETB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMETB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NAMETB.Location = new System.Drawing.Point(96, 126);
            this.NAMETB.Margin = new System.Windows.Forms.Padding(4);
            this.NAMETB.Multiline = false;
            this.NAMETB.Name = "NAMETB";
            this.NAMETB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NAMETB.PasswordChar = false;
            this.NAMETB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NAMETB.PlaceholderText = "NAME";
            this.NAMETB.Size = new System.Drawing.Size(250, 31);
            this.NAMETB.TabIndex = 19;
            this.NAMETB.Texts = "";
            this.NAMETB.UnderlinedStyle = false;
            // 
            // AddTB
            // 
            this.AddTB.BackColor = System.Drawing.SystemColors.Window;
            this.AddTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.AddTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.AddTB.BorderRadius = 15;
            this.AddTB.BorderSize = 2;
            this.AddTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTB.Location = new System.Drawing.Point(96, 188);
            this.AddTB.Margin = new System.Windows.Forms.Padding(4);
            this.AddTB.Multiline = false;
            this.AddTB.Name = "AddTB";
            this.AddTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AddTB.PasswordChar = false;
            this.AddTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AddTB.PlaceholderText = "ADDRESS";
            this.AddTB.Size = new System.Drawing.Size(250, 31);
            this.AddTB.TabIndex = 20;
            this.AddTB.Texts = "";
            this.AddTB.UnderlinedStyle = false;
            // 
            // BrgTB
            // 
            this.BrgTB.BackColor = System.Drawing.SystemColors.Window;
            this.BrgTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BrgTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.BrgTB.BorderRadius = 15;
            this.BrgTB.BorderSize = 2;
            this.BrgTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrgTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrgTB.Location = new System.Drawing.Point(96, 247);
            this.BrgTB.Margin = new System.Windows.Forms.Padding(4);
            this.BrgTB.Multiline = false;
            this.BrgTB.Name = "BrgTB";
            this.BrgTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.BrgTB.PasswordChar = false;
            this.BrgTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BrgTB.PlaceholderText = "BARANGAY";
            this.BrgTB.Size = new System.Drawing.Size(250, 31);
            this.BrgTB.TabIndex = 21;
            this.BrgTB.Texts = "";
            this.BrgTB.UnderlinedStyle = false;
            // 
            // CNTB
            // 
            this.CNTB.BackColor = System.Drawing.SystemColors.Window;
            this.CNTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.CNTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CNTB.BorderRadius = 15;
            this.CNTB.BorderSize = 2;
            this.CNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CNTB.Location = new System.Drawing.Point(96, 305);
            this.CNTB.Margin = new System.Windows.Forms.Padding(4);
            this.CNTB.Multiline = false;
            this.CNTB.Name = "CNTB";
            this.CNTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CNTB.PasswordChar = false;
            this.CNTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CNTB.PlaceholderText = "CONTACT NUMBER";
            this.CNTB.Size = new System.Drawing.Size(250, 31);
            this.CNTB.TabIndex = 22;
            this.CNTB.Texts = "";
            this.CNTB.UnderlinedStyle = false;
            // 
            // DepTB
            // 
            this.DepTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DepTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DepTB.BorderSize = 1;
            this.DepTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.DepTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DepTB.ForeColor = System.Drawing.Color.DimGray;
            this.DepTB.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.DepTB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DepTB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.DepTB.ListTextColor = System.Drawing.Color.DimGray;
            this.DepTB.Location = new System.Drawing.Point(96, 367);
            this.DepTB.MinimumSize = new System.Drawing.Size(200, 30);
            this.DepTB.Name = "DepTB";
            this.DepTB.Padding = new System.Windows.Forms.Padding(1);
            this.DepTB.Size = new System.Drawing.Size(250, 30);
            this.DepTB.TabIndex = 23;
            this.DepTB.Texts = "";
            // 
            // CPTB
            // 
            this.CPTB.BackColor = System.Drawing.SystemColors.Window;
            this.CPTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.CPTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CPTB.BorderRadius = 15;
            this.CPTB.BorderSize = 2;
            this.CPTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPTB.Location = new System.Drawing.Point(539, 68);
            this.CPTB.Margin = new System.Windows.Forms.Padding(4);
            this.CPTB.Multiline = false;
            this.CPTB.Name = "CPTB";
            this.CPTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CPTB.PasswordChar = false;
            this.CPTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CPTB.PlaceholderText = "CONTACT PERSON";
            this.CPTB.Size = new System.Drawing.Size(250, 31);
            this.CPTB.TabIndex = 24;
            this.CPTB.Texts = "";
            this.CPTB.UnderlinedStyle = false;
            // 
            // CPNTB
            // 
            this.CPNTB.BackColor = System.Drawing.SystemColors.Window;
            this.CPNTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.CPNTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CPNTB.BorderRadius = 15;
            this.CPNTB.BorderSize = 2;
            this.CPNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPNTB.Location = new System.Drawing.Point(539, 126);
            this.CPNTB.Margin = new System.Windows.Forms.Padding(4);
            this.CPNTB.Multiline = false;
            this.CPNTB.Name = "CPNTB";
            this.CPNTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CPNTB.PasswordChar = false;
            this.CPNTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CPNTB.PlaceholderText = "CONTACT NUMBER";
            this.CPNTB.Size = new System.Drawing.Size(250, 31);
            this.CPNTB.TabIndex = 25;
            this.CPNTB.Texts = "";
            this.CPNTB.UnderlinedStyle = false;
            // 
            // RelTB
            // 
            this.RelTB.BackColor = System.Drawing.SystemColors.Window;
            this.RelTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RelTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RelTB.BorderRadius = 15;
            this.RelTB.BorderSize = 2;
            this.RelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RelTB.Location = new System.Drawing.Point(539, 188);
            this.RelTB.Margin = new System.Windows.Forms.Padding(4);
            this.RelTB.Multiline = false;
            this.RelTB.Name = "RelTB";
            this.RelTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RelTB.PasswordChar = false;
            this.RelTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RelTB.PlaceholderText = "RELATIONSHIP";
            this.RelTB.Size = new System.Drawing.Size(250, 31);
            this.RelTB.TabIndex = 26;
            this.RelTB.Texts = "";
            this.RelTB.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(539, 272);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(110, 40);
            this.rjButton1.TabIndex = 27;
            this.rjButton1.Text = "ADD";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Evacuee_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.RelTB);
            this.Controls.Add(this.CPNTB);
            this.Controls.Add(this.CPTB);
            this.Controls.Add(this.DepTB);
            this.Controls.Add(this.CNTB);
            this.Controls.Add(this.BrgTB);
            this.Controls.Add(this.AddTB);
            this.Controls.Add(this.NAMETB);
            this.Controls.Add(this.RFIDTB);
            this.Controls.Add(this.button1);
            this.Name = "Evacuee_Registration";
            this.Text = "Evacuee_Registration";
            this.Load += new System.EventHandler(this.Evacuee_Registration_Load);
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RJCodeAdvance.RJControls.RJTextBox RFIDTB;
        private RJCodeAdvance.RJControls.RJTextBox NAMETB;
        private RJCodeAdvance.RJControls.RJTextBox AddTB;
        private RJCodeAdvance.RJControls.RJTextBox BrgTB;
        private RJCodeAdvance.RJControls.RJTextBox CNTB;
        private RJCodeAdvance.RJControls.RJComboBox DepTB;
        private RJCodeAdvance.RJControls.RJTextBox CPTB;
        private RJCodeAdvance.RJControls.RJTextBox CPNTB;
        private RJCodeAdvance.RJControls.RJTextBox RelTB;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
    }
}