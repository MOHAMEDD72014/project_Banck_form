namespace DVLDFormLayer.Local_Driving
{
    partial class ManageLocalDrivingForm
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
            this.components = new System.ComponentModel.Container();
            this.txtSearchApp = new System.Windows.Forms.MaskedTextBox();
            this.dgvLocalDriving = new System.Windows.Forms.DataGridView();
            this.cmsEditeUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetailsUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEdditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordApp = new System.Windows.Forms.Label();
            this.cbFilterApp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDriving)).BeginInit();
            this.cmsEditeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchApp
            // 
            this.txtSearchApp.Location = new System.Drawing.Point(213, 227);
            this.txtSearchApp.Name = "txtSearchApp";
            this.txtSearchApp.Size = new System.Drawing.Size(161, 20);
            this.txtSearchApp.TabIndex = 32;
            this.txtSearchApp.Visible = false;
            this.txtSearchApp.TextChanged += new System.EventHandler(this.txtSearchApp_TextChanged);
            // 
            // dgvLocalDriving
            // 
            this.dgvLocalDriving.AllowUserToAddRows = false;
            this.dgvLocalDriving.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDriving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDriving.ContextMenuStrip = this.cmsEditeUser;
            this.dgvLocalDriving.Location = new System.Drawing.Point(18, 256);
            this.dgvLocalDriving.Name = "dgvLocalDriving";
            this.dgvLocalDriving.RowHeadersVisible = false;
            this.dgvLocalDriving.Size = new System.Drawing.Size(876, 265);
            this.dgvLocalDriving.TabIndex = 31;
            // 
            // cmsEditeUser
            // 
            this.cmsEditeUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetailsUser,
            this.TsmEdditApplication,
            this.tsmDelete,
            this.tsmCancelApplication,
            this.tsmSechduleTests,
            this.tsmIssueDrivingLicense,
            this.tsmShowLicense,
            this.tsmShowPersonLicenseHistory});
            this.cmsEditeUser.Name = "cmsEdite";
            this.cmsEditeUser.Size = new System.Drawing.Size(243, 202);
            this.cmsEditeUser.Text = "Edite";
            this.cmsEditeUser.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEditeUser_Opening);
            // 
            // tsmShowDetailsUser
            // 
            this.tsmShowDetailsUser.Image = global::DVLDFormLayer.Properties.Resources.PersonDetails_32;
            this.tsmShowDetailsUser.Name = "tsmShowDetailsUser";
            this.tsmShowDetailsUser.Size = new System.Drawing.Size(242, 22);
            this.tsmShowDetailsUser.Text = "Show Details";
            this.tsmShowDetailsUser.Click += new System.EventHandler(this.tsmShowDetailsUser_Click);
            // 
            // TsmEdditApplication
            // 
            this.TsmEdditApplication.Image = global::DVLDFormLayer.Properties.Resources.edit_32;
            this.TsmEdditApplication.Name = "TsmEdditApplication";
            this.TsmEdditApplication.Size = new System.Drawing.Size(242, 22);
            this.TsmEdditApplication.Text = "Eddit Application";
            this.TsmEdditApplication.Click += new System.EventHandler(this.TsmEdditApplication_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::DVLDFormLayer.Properties.Resources.Delete_32_2;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(242, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Image = global::DVLDFormLayer.Properties.Resources.Delete_321;
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(242, 22);
            this.tsmCancelApplication.Text = "Cancel Application";
            this.tsmCancelApplication.Click += new System.EventHandler(this.tsmCancelApplication_Click);
            // 
            // tsmSechduleTests
            // 
            this.tsmSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleWrittenTest,
            this.tsmScheduleStreetTest});
            this.tsmSechduleTests.Image = global::DVLDFormLayer.Properties.Resources.Schedule_Test_321;
            this.tsmSechduleTests.Name = "tsmSechduleTests";
            this.tsmSechduleTests.Size = new System.Drawing.Size(242, 22);
            this.tsmSechduleTests.Text = "Sechdule Tests";
            // 
            // tsmScheduleVisionTest
            // 
            this.tsmScheduleVisionTest.Image = global::DVLDFormLayer.Properties.Resources.Vision_Test_32;
            this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
            this.tsmScheduleVisionTest.Size = new System.Drawing.Size(187, 22);
            this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmScheduleVisionTest.Click += new System.EventHandler(this.tsmScheduleVisionTest_Click);
            // 
            // tsmScheduleWrittenTest
            // 
            this.tsmScheduleWrittenTest.Enabled = false;
            this.tsmScheduleWrittenTest.Image = global::DVLDFormLayer.Properties.Resources.Written_Test_32;
            this.tsmScheduleWrittenTest.Name = "tsmScheduleWrittenTest";
            this.tsmScheduleWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.tsmScheduleWrittenTest.Text = "Schedule Written Test";
            this.tsmScheduleWrittenTest.Click += new System.EventHandler(this.tsmScheduleWrittenTest_Click);
            // 
            // tsmScheduleStreetTest
            // 
            this.tsmScheduleStreetTest.Enabled = false;
            this.tsmScheduleStreetTest.Image = global::DVLDFormLayer.Properties.Resources.Street_Test_32;
            this.tsmScheduleStreetTest.Name = "tsmScheduleStreetTest";
            this.tsmScheduleStreetTest.Size = new System.Drawing.Size(187, 22);
            this.tsmScheduleStreetTest.Text = "Schedule Street Test";
            this.tsmScheduleStreetTest.Click += new System.EventHandler(this.tsmScheduleStreetTest_Click);
            // 
            // tsmIssueDrivingLicense
            // 
            this.tsmIssueDrivingLicense.Enabled = false;
            this.tsmIssueDrivingLicense.Image = global::DVLDFormLayer.Properties.Resources.IssueDrivingLicense_32;
            this.tsmIssueDrivingLicense.Name = "tsmIssueDrivingLicense";
            this.tsmIssueDrivingLicense.Size = new System.Drawing.Size(242, 22);
            this.tsmIssueDrivingLicense.Text = "Issue Driving License(First Time)";
            this.tsmIssueDrivingLicense.Click += new System.EventHandler(this.tsmIssueDrivingLicense_Click);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Enabled = false;
            this.tsmShowLicense.Image = global::DVLDFormLayer.Properties.Resources.License_View_32;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(242, 22);
            this.tsmShowLicense.Text = "Show License";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Image = global::DVLDFormLayer.Properties.Resources.PersonLicenseHistory_32;
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(242, 22);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // lblRecordApp
            // 
            this.lblRecordApp.AutoSize = true;
            this.lblRecordApp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordApp.Location = new System.Drawing.Point(100, 527);
            this.lblRecordApp.Name = "lblRecordApp";
            this.lblRecordApp.Size = new System.Drawing.Size(15, 16);
            this.lblRecordApp.TabIndex = 30;
            this.lblRecordApp.Text = "0";
            // 
            // cbFilterApp
            // 
            this.cbFilterApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterApp.FormattingEnabled = true;
            this.cbFilterApp.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilterApp.Location = new System.Drawing.Point(84, 227);
            this.cbFilterApp.Name = "cbFilterApp";
            this.cbFilterApp.Size = new System.Drawing.Size(121, 21);
            this.cbFilterApp.TabIndex = 26;
            this.cbFilterApp.SelectedIndexChanged += new System.EventHandler(this.cbFilterApp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(283, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Local Driving License Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "# Records:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLDFormLayer.Properties.Resources.New_Application_641;
            this.pictureBox2.Location = new System.Drawing.Point(843, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(791, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(385, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ManageLocalDrivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchApp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLocalDriving);
            this.Controls.Add(this.lblRecordApp);
            this.Controls.Add(this.cbFilterApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "ManageLocalDrivingForm";
            this.Text = "ManageLocalDrivingForm";
            this.Load += new System.EventHandler(this.ManageLocalDrivingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDriving)).EndInit();
            this.cmsEditeUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtSearchApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmSechduleTests;
        private System.Windows.Forms.DataGridView dgvLocalDriving;
        private System.Windows.Forms.ContextMenuStrip cmsEditeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetailsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem TsmEdditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Label lblRecordApp;
        private System.Windows.Forms.ComboBox cbFilterApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}