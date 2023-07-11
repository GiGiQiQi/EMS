
namespace EMS
{
    partial class Add_Site_Form
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
            this.ENAME = new System.Windows.Forms.TextBox();
            this.EADD = new System.Windows.Forms.TextBox();
            this.ECAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BADD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BUP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ETYPE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ENAME
            // 
            this.ENAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ENAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENAME.Location = new System.Drawing.Point(81, 157);
            this.ENAME.Margin = new System.Windows.Forms.Padding(2);
            this.ENAME.Name = "ENAME";
            this.ENAME.Size = new System.Drawing.Size(235, 26);
            this.ENAME.TabIndex = 0;
            // 
            // EADD
            // 
            this.EADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EADD.Location = new System.Drawing.Point(81, 316);
            this.EADD.Margin = new System.Windows.Forms.Padding(2);
            this.EADD.Name = "EADD";
            this.EADD.Size = new System.Drawing.Size(235, 26);
            this.EADD.TabIndex = 1;
            // 
            // ECAP
            // 
            this.ECAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ECAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECAP.Location = new System.Drawing.Point(81, 395);
            this.ECAP.Margin = new System.Windows.Forms.Padding(2);
            this.ECAP.Name = "ECAP";
            this.ECAP.Size = new System.Drawing.Size(235, 26);
            this.ECAP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evacuation Site Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.label2.Location = new System.Drawing.Point(78, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.label3.Location = new System.Drawing.Point(78, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Establisment Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.label4.Location = new System.Drawing.Point(78, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacity";
            // 
            // BADD
            // 
            this.BADD.Location = new System.Drawing.Point(392, 441);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(110, 32);
            this.BADD.TabIndex = 8;
            this.BADD.Text = "ADD";
            this.BADD.UseVisualStyleBackColor = true;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Evacuation Site ID";
            // 
            // EID
            // 
            this.EID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EID.Location = new System.Drawing.Point(81, 80);
            this.EID.Margin = new System.Windows.Forms.Padding(2);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(235, 26);
            this.EID.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 341);
            this.dataGridView1.TabIndex = 11;
            // 
            // BUP
            // 
            this.BUP.Location = new System.Drawing.Point(520, 441);
            this.BUP.Name = "BUP";
            this.BUP.Size = new System.Drawing.Size(110, 32);
            this.BUP.TabIndex = 12;
            this.BUP.Text = "UPDATE";
            this.BUP.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ETYPE
            // 
            this.ETYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETYPE.FormattingEnabled = true;
            this.ETYPE.Items.AddRange(new object[] {
            "School",
            "Gymnasium",
            "Court",
            "Center"});
            this.ETYPE.Location = new System.Drawing.Point(81, 242);
            this.ETYPE.Name = "ETYPE";
            this.ETYPE.Size = new System.Drawing.Size(235, 28);
            this.ETYPE.TabIndex = 14;
            // 
            // Add_Site_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 485);
            this.Controls.Add(this.ETYPE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BUP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ECAP);
            this.Controls.Add(this.EADD);
            this.Controls.Add(this.ENAME);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Site_Form";
            this.Text = "Add Site";
            this.Load += new System.EventHandler(this.Add_Site_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ENAME;
        private System.Windows.Forms.TextBox EADD;
        private System.Windows.Forms.TextBox ECAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BUP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ETYPE;
    }
}