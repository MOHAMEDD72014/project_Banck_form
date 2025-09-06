namespace DVLDFormLayer.International
{
    partial class MangerInternatinalForm
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
            this.txtSerch = new System.Windows.Forms.MaskedTextBox();
            this.dgvInterntinal = new System.Windows.Forms.DataGridView();
            this.cmsInternatinal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRecordUser = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicinse = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntinal)).BeginInit();
            this.cmsInternatinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerch
            // 
            this.txtSerch.Location = new System.Drawing.Point(213, 193);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(161, 20);
            this.txtSerch.TabIndex = 32;
            this.txtSerch.Visible = false;
            this.txtSerch.TextChanged += new System.EventHandler(this.txtSerch_TextChanged);
            // 
            // dgvInterntinal
            // 
            this.dgvInterntinal.AllowUserToAddRows = false;
            this.dgvInterntinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterntinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterntinal.ContextMenuStrip = this.cmsInternatinal;
            this.dgvInterntinal.Location = new System.Drawing.Point(18, 222);
            this.dgvInterntinal.Name = "dgvInterntinal";
            this.dgvInterntinal.RowHeadersVisible = false;
            this.dgvInterntinal.Size = new System.Drawing.Size(876, 265);
            this.dgvInterntinal.TabIndex = 31;
            // 
            // cmsInternatinal
            // 
            this.cmsInternatinal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmShowLicinse,
            this.TsmHistory});
            this.cmsInternatinal.Name = "cmsEdite";
            this.cmsInternatinal.Size = new System.Drawing.Size(226, 70);
            this.cmsInternatinal.Text = "Edite";
            // 
            // lblRecordUser
            // 
            this.lblRecordUser.AutoSize = true;
            this.lblRecordUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordUser.Location = new System.Drawing.Point(100, 493);
            this.lblRecordUser.Name = "lblRecordUser";
            this.lblRecordUser.Size = new System.Drawing.Size(15, 16);
            this.lblRecordUser.TabIndex = 30;
            this.lblRecordUser.Text = "0";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "InternationalLicenseID",
            "ApplicationID",
            "DriverID",
            "IssuedUsingLocalLicenseID",
            "IssueDate",
            "ExpirationDate",
            "IsActive",
            "CreatedByUserID"});
            this.cbFilter.Location = new System.Drawing.Point(84, 193);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 26;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(271, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Internatinal License Applicatin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "# Records:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLDFormLayer.Properties.Resources.New_Application_641;
            this.pictureBox2.Location = new System.Drawing.Point(846, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(791, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(385, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::DVLDFormLayer.Properties.Resources.PersonDetails_32;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(225, 22);
            this.tsmShowDetails.Text = "Show Person Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // tsmShowLicinse
            // 
            this.tsmShowLicinse.Image = global::DVLDFormLayer.Properties.Resources.License_View_324;
            this.tsmShowLicinse.Name = "tsmShowLicinse";
            this.tsmShowLicinse.Size = new System.Drawing.Size(225, 22);
            this.tsmShowLicinse.Text = "Show Licinse Details";
            this.tsmShowLicinse.Click += new System.EventHandler(this.tsmShowLicinse_Click);
            // 
            // TsmHistory
            // 
            this.TsmHistory.Image = global::DVLDFormLayer.Properties.Resources.PersonLicenseHistory_321;
            this.TsmHistory.Name = "TsmHistory";
            this.TsmHistory.Size = new System.Drawing.Size(225, 22);
            this.TsmHistory.Text = "Show Person License History";
            this.TsmHistory.Click += new System.EventHandler(this.TsmHistory_Click);
            // 
            // MangerInternatinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSerch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInterntinal);
            this.Controls.Add(this.lblRecordUser);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MangerInternatinalForm";
            this.Text = "MangerInternatinalForm";
            this.Load += new System.EventHandler(this.MangerInternatinalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterntinal)).EndInit();
            this.cmsInternatinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtSerch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvInterntinal;
        private System.Windows.Forms.ContextMenuStrip cmsInternatinal;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicinse;
        private System.Windows.Forms.ToolStripMenuItem TsmHistory;
        private System.Windows.Forms.Label lblRecordUser;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}