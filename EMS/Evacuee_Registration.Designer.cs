
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
            this.AddTB = new System.Windows.Forms.TextBox();
            this.BrgTB = new System.Windows.Forms.TextBox();
            this.CNTB = new System.Windows.Forms.TextBox();
            this.CPTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CPNTB = new System.Windows.Forms.TextBox();
            this.RelTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DepTB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RFIDTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NAMETB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTB
            // 
            this.AddTB.Location = new System.Drawing.Point(184, 205);
            this.AddTB.Name = "AddTB";
            this.AddTB.Size = new System.Drawing.Size(204, 20);
            this.AddTB.TabIndex = 1;
            // 
            // BrgTB
            // 
            this.BrgTB.Location = new System.Drawing.Point(184, 273);
            this.BrgTB.Name = "BrgTB";
            this.BrgTB.Size = new System.Drawing.Size(204, 20);
            this.BrgTB.TabIndex = 2;
            // 
            // CNTB
            // 
            this.CNTB.Location = new System.Drawing.Point(184, 336);
            this.CNTB.Name = "CNTB";
            this.CNTB.Size = new System.Drawing.Size(204, 20);
            this.CNTB.TabIndex = 3;
            // 
            // CPTB
            // 
            this.CPTB.Location = new System.Drawing.Point(528, 110);
            this.CPTB.Name = "CPTB";
            this.CPTB.Size = new System.Drawing.Size(220, 20);
            this.CPTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barangay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Person";
            // 
            // CPNTB
            // 
            this.CPNTB.Location = new System.Drawing.Point(528, 170);
            this.CPNTB.Name = "CPNTB";
            this.CPNTB.Size = new System.Drawing.Size(220, 20);
            this.CPNTB.TabIndex = 10;
            // 
            // RelTB
            // 
            this.RelTB.Location = new System.Drawing.Point(528, 238);
            this.RelTB.Name = "RelTB";
            this.RelTB.Size = new System.Drawing.Size(220, 20);
            this.RelTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Relationship";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepTB
            // 
            this.DepTB.FormattingEnabled = true;
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
            this.DepTB.Location = new System.Drawing.Point(184, 408);
            this.DepTB.Name = "DepTB";
            this.DepTB.Size = new System.Drawing.Size(204, 21);
            this.DepTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of Dependents";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "EVACUEES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RFIDTB
            // 
            this.RFIDTB.Location = new System.Drawing.Point(184, 75);
            this.RFIDTB.Name = "RFIDTB";
            this.RFIDTB.Size = new System.Drawing.Size(204, 20);
            this.RFIDTB.TabIndex = 18;
            this.RFIDTB.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "RFID";
            // 
            // NAMETB
            // 
            this.NAMETB.Location = new System.Drawing.Point(184, 147);
            this.NAMETB.Name = "NAMETB";
            this.NAMETB.Size = new System.Drawing.Size(204, 20);
            this.NAMETB.TabIndex = 20;
            // 
            // Evacuee_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.NAMETB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RFIDTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DepTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RelTB);
            this.Controls.Add(this.CPNTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPTB);
            this.Controls.Add(this.CNTB);
            this.Controls.Add(this.BrgTB);
            this.Controls.Add(this.AddTB);
            this.Name = "Evacuee_Registration";
            this.Text = "Evacuee_Registration";
            this.Load += new System.EventHandler(this.Evacuee_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox AddTB;
        private System.Windows.Forms.TextBox BrgTB;
        private System.Windows.Forms.TextBox CNTB;
        private System.Windows.Forms.TextBox CPTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CPNTB;
        private System.Windows.Forms.TextBox RelTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DepTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RFIDTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NAMETB;
    }
}