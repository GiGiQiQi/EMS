﻿
namespace EMS
{
    partial class FAssign
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.RIDTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.TNCB = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.rjButton1.Location = new System.Drawing.Point(95, 373);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Assign";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // RIDTB
            // 
            this.RIDTB.BackColor = System.Drawing.SystemColors.Window;
            this.RIDTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RIDTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RIDTB.BorderRadius = 10;
            this.RIDTB.BorderSize = 1;
            this.RIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIDTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RIDTB.Location = new System.Drawing.Point(48, 136);
            this.RIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.RIDTB.Multiline = false;
            this.RIDTB.Name = "RIDTB";
            this.RIDTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RIDTB.PasswordChar = false;
            this.RIDTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RIDTB.PlaceholderText = "";
            this.RIDTB.Size = new System.Drawing.Size(250, 31);
            this.RIDTB.TabIndex = 2;
            this.RIDTB.Texts = "";
            this.RIDTB.UnderlinedStyle = false;
            // 
            // TNCB
            // 
            this.TNCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TNCB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TNCB.BorderSize = 1;
            this.TNCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.TNCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TNCB.ForeColor = System.Drawing.Color.DimGray;
            this.TNCB.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.TNCB.Items.AddRange(new object[] {
            "TEAM 1",
            "TEAM 2",
            "TEAM 3",
            "TEAM 4",
            "TEAM 5",
            "TEAM 6",
            "TEAM 7",
            "TEAM 8",
            "TEAM 9",
            "TEAM 10"});
            this.TNCB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.TNCB.ListTextColor = System.Drawing.Color.DimGray;
            this.TNCB.Location = new System.Drawing.Point(51, 204);
            this.TNCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.TNCB.Name = "TNCB";
            this.TNCB.Padding = new System.Windows.Forms.Padding(1);
            this.TNCB.Size = new System.Drawing.Size(250, 30);
            this.TNCB.TabIndex = 3;
            this.TNCB.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rescuer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team Number";
            // 
            // LocTB
            // 
            this.LocTB.BackColor = System.Drawing.SystemColors.Window;
            this.LocTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.LocTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LocTB.BorderRadius = 10;
            this.LocTB.BorderSize = 1;
            this.LocTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LocTB.Location = new System.Drawing.Point(51, 282);
            this.LocTB.Margin = new System.Windows.Forms.Padding(4);
            this.LocTB.Multiline = false;
            this.LocTB.Name = "LocTB";
            this.LocTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LocTB.PasswordChar = false;
            this.LocTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LocTB.PlaceholderText = "";
            this.LocTB.Size = new System.Drawing.Size(250, 31);
            this.LocTB.TabIndex = 4;
            this.LocTB.Texts = "";
            this.LocTB.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TNCB);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RIDTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LocTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 485);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 485);
            this.panel2.TabIndex = 11;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // FAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FAssign";
            this.Text = "FAssign";
            this.Load += new System.EventHandler(this.FAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJTextBox RIDTB;
        private RJCodeAdvance.RJControls.RJComboBox TNCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox LocTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}