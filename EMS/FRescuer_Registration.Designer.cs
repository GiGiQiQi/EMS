
namespace EMS
{
    partial class FRescuer_Registration
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
            this.ADD = new System.Windows.Forms.Button();
            this.UPD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.RName = new RJCodeAdvance.RJControls.RJTextBox();
            this.RAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.RCont = new RJCodeAdvance.RJControls.RJTextBox();
            this.RGender = new RJCodeAdvance.RJControls.RJComboBox();
            this.RGen = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(418, 440);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 11;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // UPD
            // 
            this.UPD.Location = new System.Drawing.Point(523, 440);
            this.UPD.Name = "UPD";
            this.UPD.Size = new System.Drawing.Size(75, 23);
            this.UPD.TabIndex = 12;
            this.UPD.Text = "Update";
            this.UPD.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(312, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 346);
            this.dataGridView1.TabIndex = 13;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(31, 60);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "RFID";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 14;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // RName
            // 
            this.RName.BackColor = System.Drawing.SystemColors.Window;
            this.RName.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RName.BorderRadius = 0;
            this.RName.BorderSize = 2;
            this.RName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RName.Location = new System.Drawing.Point(31, 113);
            this.RName.Margin = new System.Windows.Forms.Padding(4);
            this.RName.Multiline = false;
            this.RName.Name = "RName";
            this.RName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RName.PasswordChar = false;
            this.RName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RName.PlaceholderText = "NAME";
            this.RName.Size = new System.Drawing.Size(250, 31);
            this.RName.TabIndex = 15;
            this.RName.Texts = "";
            this.RName.UnderlinedStyle = true;
            // 
            // RAddress
            // 
            this.RAddress.BackColor = System.Drawing.SystemColors.Window;
            this.RAddress.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RAddress.BorderRadius = 0;
            this.RAddress.BorderSize = 2;
            this.RAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RAddress.Location = new System.Drawing.Point(31, 167);
            this.RAddress.Margin = new System.Windows.Forms.Padding(4);
            this.RAddress.Multiline = false;
            this.RAddress.Name = "RAddress";
            this.RAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RAddress.PasswordChar = false;
            this.RAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RAddress.PlaceholderText = "ADDRESS";
            this.RAddress.Size = new System.Drawing.Size(250, 31);
            this.RAddress.TabIndex = 16;
            this.RAddress.Texts = "";
            this.RAddress.UnderlinedStyle = true;
            // 
            // RCont
            // 
            this.RCont.BackColor = System.Drawing.SystemColors.Window;
            this.RCont.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RCont.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RCont.BorderRadius = 0;
            this.RCont.BorderSize = 2;
            this.RCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RCont.Location = new System.Drawing.Point(31, 222);
            this.RCont.Margin = new System.Windows.Forms.Padding(4);
            this.RCont.Multiline = false;
            this.RCont.Name = "RCont";
            this.RCont.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RCont.PasswordChar = false;
            this.RCont.PlaceholderColor = System.Drawing.Color.DimGray;
            this.RCont.PlaceholderText = "CONTACT NUMBER";
            this.RCont.Size = new System.Drawing.Size(250, 31);
            this.RCont.TabIndex = 17;
            this.RCont.Texts = "";
            this.RCont.UnderlinedStyle = true;
            // 
            // RGender
            // 
            this.RGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RGender.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RGender.BorderSize = 1;
            this.RGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.RGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RGender.ForeColor = System.Drawing.Color.DimGray;
            this.RGender.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.RGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.RGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.RGender.ListTextColor = System.Drawing.Color.DimGray;
            this.RGender.Location = new System.Drawing.Point(35, 307);
            this.RGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.RGender.Name = "RGender";
            this.RGender.Padding = new System.Windows.Forms.Padding(1);
            this.RGender.Size = new System.Drawing.Size(250, 30);
            this.RGender.TabIndex = 18;
            this.RGender.Texts = "";
            // 
            // RGen
            // 
            this.RGen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RGen.BorderSize = 0;
            this.RGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RGen.Location = new System.Drawing.Point(35, 371);
            this.RGen.MinimumSize = new System.Drawing.Size(0, 35);
            this.RGen.Name = "RGen";
            this.RGen.Size = new System.Drawing.Size(250, 35);
            this.RGen.SkinColor = System.Drawing.Color.DarkSlateBlue;
            this.RGen.TabIndex = 19;
            this.RGen.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(35, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "GENDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(38, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "BIRTHDATE";
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
            this.rjButton1.Location = new System.Drawing.Point(852, 423);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(99, 40);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "ADD";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // FRescuer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RGen);
            this.Controls.Add(this.RGender);
            this.Controls.Add(this.RCont);
            this.Controls.Add(this.RAddress);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UPD);
            this.Controls.Add(this.ADD);
            this.Name = "FRescuer_Registration";
            this.Text = "FRescuer_Registration";
            this.Load += new System.EventHandler(this.FRescuer_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button UPD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox RName;
        private RJCodeAdvance.RJControls.RJTextBox RAddress;
        private RJCodeAdvance.RJControls.RJTextBox RCont;
        private RJCodeAdvance.RJControls.RJComboBox RGender;
        private RJCodeAdvance.RJControls.RJDatePicker RGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
    }
}