namespace DVLDFormLayer
{
    partial class ManagePeopleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsEdite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearch = new System.Windows.Forms.MaskedTextBox();
            this.cmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEddit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewPeople = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsEdite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(372, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "DateOfBirth",
            "Gendor",
            "Address",
            "Phone",
            "Email",
            "NationalityCountryID"});
            this.cbFilter.Location = new System.Drawing.Point(76, 179);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Records:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(92, 479);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(15, 16);
            this.lblRecord.TabIndex = 9;
            this.lblRecord.Text = "0";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsEdite;
            this.dgvPeople.Location = new System.Drawing.Point(10, 208);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.Size = new System.Drawing.Size(876, 265);
            this.dgvPeople.TabIndex = 10;
            // 
            // cmsEdite
            // 
            this.cmsEdite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDetails,
            this.cmsAddNew,
            this.cmsEddit,
            this.cmsDelete,
            this.cmsSendEmail,
            this.cmsPhoneCall});
            this.cmsEdite.Name = "cmsEdite";
            this.cmsEdite.Size = new System.Drawing.Size(163, 136);
            this.cmsEdite.Text = "Edite";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(203, 179);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmsShowDetails
            // 
            this.cmsShowDetails.Image = global::DVLDFormLayer.Properties.Resources.PersonDetails_32;
            this.cmsShowDetails.Name = "cmsShowDetails";
            this.cmsShowDetails.Size = new System.Drawing.Size(162, 22);
            this.cmsShowDetails.Text = "Show Details";
            this.cmsShowDetails.Click += new System.EventHandler(this.cmsShowDetails_Click);
            // 
            // cmsAddNew
            // 
            this.cmsAddNew.Image = global::DVLDFormLayer.Properties.Resources.AddPerson_32;
            this.cmsAddNew.Name = "cmsAddNew";
            this.cmsAddNew.Size = new System.Drawing.Size(162, 22);
            this.cmsAddNew.Text = "Add New Person";
            this.cmsAddNew.Click += new System.EventHandler(this.cmsAddNew_Click);
            // 
            // cmsEddit
            // 
            this.cmsEddit.Image = global::DVLDFormLayer.Properties.Resources.edit_32;
            this.cmsEddit.Name = "cmsEddit";
            this.cmsEddit.Size = new System.Drawing.Size(162, 22);
            this.cmsEddit.Text = "Eddt";
            this.cmsEddit.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::DVLDFormLayer.Properties.Resources.Delete_32;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(162, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsSendEmail
            // 
            this.cmsSendEmail.Image = global::DVLDFormLayer.Properties.Resources.send_email_32;
            this.cmsSendEmail.Name = "cmsSendEmail";
            this.cmsSendEmail.Size = new System.Drawing.Size(162, 22);
            this.cmsSendEmail.Text = "Send Email";
            // 
            // cmsPhoneCall
            // 
            this.cmsPhoneCall.Image = global::DVLDFormLayer.Properties.Resources.call_32;
            this.cmsPhoneCall.Name = "cmsPhoneCall";
            this.cmsPhoneCall.Size = new System.Drawing.Size(162, 22);
            this.cmsPhoneCall.Text = "Phone Call";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(783, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewPeople
            // 
            this.btnAddNewPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPeople.Image = global::DVLDFormLayer.Properties.Resources.Add_Person_40;
            this.btnAddNewPeople.Location = new System.Drawing.Point(822, 163);
            this.btnAddNewPeople.Name = "btnAddNewPeople";
            this.btnAddNewPeople.Size = new System.Drawing.Size(64, 39);
            this.btnAddNewPeople.TabIndex = 4;
            this.btnAddNewPeople.UseVisualStyleBackColor = true;
            this.btnAddNewPeople.Click += new System.EventHandler(this.btnAddNewPeople_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(377, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 523);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewPeople);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePeopleForm";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsEdite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAddNewPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.MaskedTextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsEdite;
        private System.Windows.Forms.ToolStripMenuItem cmsEddit;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsAddNew;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
    }
}