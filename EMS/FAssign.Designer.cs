
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TNCB = new RJCodeAdvance.RJControls.RJTextBox();
            this.RFIDTB2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.RFIDTB1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjRadioButton1 = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rjRadioButton2 = new RJCodeAdvance.RJControls.RJRadioButton();
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
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(448, 419);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Assign";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // RIDTB
            // 
            this.RIDTB.BackColor = System.Drawing.SystemColors.Window;
            this.RIDTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RIDTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RIDTB.BorderRadius = 10;
            this.RIDTB.BorderSize = 1;
            this.RIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIDTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RIDTB.Location = new System.Drawing.Point(51, 77);
            this.RIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.RIDTB.Multiline = false;
            this.RIDTB.Name = "RIDTB";
            this.RIDTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RIDTB.PasswordChar = false;
            this.RIDTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RIDTB.PlaceholderText = "";
            this.RIDTB.Size = new System.Drawing.Size(250, 35);
            this.RIDTB.TabIndex = 2;
            this.RIDTB.Texts = "";
            this.RIDTB.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rescuer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TNCB);
            this.panel1.Controls.Add(this.RFIDTB2);
            this.panel1.Controls.Add(this.RFIDTB1);
            this.panel1.Controls.Add(this.RIDTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 485);
            this.panel1.TabIndex = 10;
            // 
            // TNCB
            // 
            this.TNCB.BackColor = System.Drawing.SystemColors.Window;
            this.TNCB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TNCB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TNCB.BorderRadius = 10;
            this.TNCB.BorderSize = 1;
            this.TNCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNCB.Location = new System.Drawing.Point(51, 258);
            this.TNCB.Margin = new System.Windows.Forms.Padding(4);
            this.TNCB.Multiline = false;
            this.TNCB.Name = "TNCB";
            this.TNCB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TNCB.PasswordChar = false;
            this.TNCB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNCB.PlaceholderText = "";
            this.TNCB.Size = new System.Drawing.Size(250, 35);
            this.TNCB.TabIndex = 12;
            this.TNCB.Texts = "";
            this.TNCB.UnderlinedStyle = false;
            // 
            // RFIDTB2
            // 
            this.RFIDTB2.BackColor = System.Drawing.SystemColors.Window;
            this.RFIDTB2.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RFIDTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RFIDTB2.BorderRadius = 10;
            this.RFIDTB2.BorderSize = 1;
            this.RFIDTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RFIDTB2.Location = new System.Drawing.Point(51, 163);
            this.RFIDTB2.Margin = new System.Windows.Forms.Padding(4);
            this.RFIDTB2.Multiline = false;
            this.RFIDTB2.Name = "RFIDTB2";
            this.RFIDTB2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RFIDTB2.PasswordChar = false;
            this.RFIDTB2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RFIDTB2.PlaceholderText = "";
            this.RFIDTB2.Size = new System.Drawing.Size(250, 35);
            this.RFIDTB2.TabIndex = 11;
            this.RFIDTB2.Texts = "";
            this.RFIDTB2.UnderlinedStyle = false;
            // 
            // RFIDTB1
            // 
            this.RFIDTB1.BackColor = System.Drawing.SystemColors.Window;
            this.RFIDTB1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.RFIDTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RFIDTB1.BorderRadius = 10;
            this.RFIDTB1.BorderSize = 1;
            this.RFIDTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RFIDTB1.Location = new System.Drawing.Point(51, 120);
            this.RFIDTB1.Margin = new System.Windows.Forms.Padding(4);
            this.RFIDTB1.Multiline = false;
            this.RFIDTB1.Name = "RFIDTB1";
            this.RFIDTB1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RFIDTB1.PasswordChar = false;
            this.RFIDTB1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.RFIDTB1.PlaceholderText = "";
            this.RFIDTB1.Size = new System.Drawing.Size(250, 35);
            this.RFIDTB1.TabIndex = 10;
            this.RFIDTB1.Texts = "";
            this.RFIDTB1.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rjRadioButton2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.rjRadioButton1);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 485);
            this.panel2.TabIndex = 11;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton1.Location = new System.Drawing.Point(29, 429);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(132, 24);
            this.rjRadioButton1.TabIndex = 1;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "Active Teams";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            this.rjRadioButton1.CheckedChanged += new System.EventHandler(this.rjRadioButton1_CheckedChanged);
            // 
            // rjRadioButton2
            // 
            this.rjRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rjRadioButton2.AutoSize = true;
            this.rjRadioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButton2.Location = new System.Drawing.Point(177, 429);
            this.rjRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton2.Name = "rjRadioButton2";
            this.rjRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton2.Size = new System.Drawing.Size(152, 24);
            this.rjRadioButton2.TabIndex = 2;
            this.rjRadioButton2.TabStop = true;
            this.rjRadioButton2.Text = "Active Rescuers";
            this.rjRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton2.UseVisualStyleBackColor = true;
            this.rjRadioButton2.CheckedChanged += new System.EventHandler(this.rjRadioButton2_CheckedChanged);
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
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJTextBox RIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox RFIDTB2;
        private RJCodeAdvance.RJControls.RJTextBox RFIDTB1;
        private RJCodeAdvance.RJControls.RJTextBox TNCB;
        private RJCodeAdvance.RJControls.RJRadioButton rjRadioButton2;
        private RJCodeAdvance.RJControls.RJRadioButton rjRadioButton1;
    }
}