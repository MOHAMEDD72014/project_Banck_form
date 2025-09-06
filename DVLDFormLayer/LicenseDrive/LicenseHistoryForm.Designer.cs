namespace DVLDFormLayer.LicenseDrive
{
    partial class LicenseHistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.tabInternatinal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.personInformation1 = new DVLDFormLayer.PersonInformation();
            this.lblRecordHistory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHostory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLocal.SuspendLayout();
            this.tabInternatinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(348, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "License History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(25, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 293);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLocal);
            this.tabControl1.Controls.Add(this.tabInternatinal);
            this.tabControl1.Location = new System.Drawing.Point(6, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.lblRecord);
            this.tabLocal.Controls.Add(this.label3);
            this.tabLocal.Controls.Add(this.dgvLocal);
            this.tabLocal.Controls.Add(this.label2);
            this.tabLocal.Location = new System.Drawing.Point(4, 25);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(1014, 230);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // tabInternatinal
            // 
            this.tabInternatinal.Controls.Add(this.lblRecordHistory);
            this.tabInternatinal.Controls.Add(this.label5);
            this.tabInternatinal.Controls.Add(this.dgvHostory);
            this.tabInternatinal.Controls.Add(this.label6);
            this.tabInternatinal.Location = new System.Drawing.Point(4, 25);
            this.tabInternatinal.Name = "tabInternatinal";
            this.tabInternatinal.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternatinal.Size = new System.Drawing.Size(1014, 230);
            this.tabInternatinal.TabIndex = 1;
            this.tabInternatinal.Text = "Internatinal";
            this.tabInternatinal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local Licenses History";
            // 
            // dgvLocal
            // 
            this.dgvLocal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Location = new System.Drawing.Point(6, 41);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(1002, 150);
            this.dgvLocal.TabIndex = 1;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(81, 202);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(15, 16);
            this.lblRecord.TabIndex = 12;
            this.lblRecord.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(773, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // personInformation1
            // 
            this.personInformation1.Location = new System.Drawing.Point(219, 72);
            this.personInformation1.Name = "personInformation1";
            this.personInformation1.NatinalNo = 0;
            this.personInformation1.PersonID = 0;
            this.personInformation1.Size = new System.Drawing.Size(842, 220);
            this.personInformation1.TabIndex = 0;
            // 
            // lblRecordHistory
            // 
            this.lblRecordHistory.AutoSize = true;
            this.lblRecordHistory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordHistory.Location = new System.Drawing.Point(83, 202);
            this.lblRecordHistory.Name = "lblRecordHistory";
            this.lblRecordHistory.Size = new System.Drawing.Size(15, 16);
            this.lblRecordHistory.TabIndex = 16;
            this.lblRecordHistory.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "# Records:";
            // 
            // dgvHostory
            // 
            this.dgvHostory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHostory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostory.Location = new System.Drawing.Point(8, 41);
            this.dgvHostory.Name = "dgvHostory";
            this.dgvHostory.Size = new System.Drawing.Size(1002, 150);
            this.dgvHostory.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "International Licenses History";
            // 
            // LicenseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LicenseHistoryForm";
            this.Text = "LicenseHistoryForm";
            this.Load += new System.EventHandler(this.LicenseHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            this.tabLocal.PerformLayout();
            this.tabInternatinal.ResumeLayout(false);
            this.tabInternatinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInformation personInformation1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.TabPage tabInternatinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHostory;
        private System.Windows.Forms.Label label6;
    }
}