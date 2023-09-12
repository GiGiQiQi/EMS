
namespace EMS
{
    partial class FHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTB = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(732, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 158);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(22, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 384);
            this.dataGridView1.TabIndex = 4;
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.SystemColors.Window;
            this.searchTB.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.searchTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTB.BorderRadius = 0;
            this.searchTB.BorderSize = 2;
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTB.Location = new System.Drawing.Point(454, 42);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Multiline = false;
            this.searchTB.Name = "searchTB";
            this.searchTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTB.PasswordChar = false;
            this.searchTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTB.PlaceholderText = "Search for Information";
            this.searchTB.Size = new System.Drawing.Size(250, 31);
            this.searchTB.TabIndex = 5;
            this.searchTB.Texts = "";
            this.searchTB.UnderlinedStyle = true;
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
            this.rjButton1.Location = new System.Drawing.Point(729, 33);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(203, 40);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Search";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(732, 101);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.DarkSlateBlue;
            this.rjDatePicker1.TabIndex = 7;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // FHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FHistory";
            this.Text = "FHistory";
            this.Load += new System.EventHandler(this.FHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox searchTB;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
    }
}