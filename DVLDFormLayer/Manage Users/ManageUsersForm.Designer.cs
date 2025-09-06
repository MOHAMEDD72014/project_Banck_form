namespace DVLDFormLayer.Manage_Users
{
    partial class ManageUsersForm
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblRecordUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterUse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerchUser = new System.Windows.Forms.MaskedTextBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cmsEditeUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tsmShowDetailsUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEditeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.cmsEditeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.ContextMenuStrip = this.cmsEditeUser;
            this.dgvUser.Location = new System.Drawing.Point(28, 223);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(876, 265);
            this.dgvUser.TabIndex = 20;
            // 
            // lblRecordUser
            // 
            this.lblRecordUser.AutoSize = true;
            this.lblRecordUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordUser.Location = new System.Drawing.Point(110, 494);
            this.lblRecordUser.Name = "lblRecordUser";
            this.lblRecordUser.Size = new System.Drawing.Size(15, 16);
            this.lblRecordUser.TabIndex = 19;
            this.lblRecordUser.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Records:";
            // 
            // cbFilterUse
            // 
            this.cbFilterUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUse.FormattingEnabled = true;
            this.cbFilterUse.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "UserID",
            "NationalNo",
            "Password",
            "IsActive"});
            this.cbFilterUse.Location = new System.Drawing.Point(94, 194);
            this.cbFilterUse.Name = "cbFilterUse";
            this.cbFilterUse.Size = new System.Drawing.Size(121, 21);
            this.cbFilterUse.TabIndex = 15;
            this.cbFilterUse.SelectedIndexChanged += new System.EventHandler(this.cbFilterUse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(390, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSerchUser
            // 
            this.txtSerchUser.Location = new System.Drawing.Point(223, 194);
            this.txtSerchUser.Name = "txtSerchUser";
            this.txtSerchUser.Size = new System.Drawing.Size(161, 20);
            this.txtSerchUser.TabIndex = 21;
            this.txtSerchUser.Visible = false;
            this.txtSerchUser.TextChanged += new System.EventHandler(this.txtSerchUser_TextChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "No",
            "Yes"});
            this.cbIsActive.Location = new System.Drawing.Point(223, 194);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(73, 21);
            this.cbIsActive.Sorted = true;
            this.cbIsActive.TabIndex = 22;
            this.cbIsActive.TabStop = false;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cmsEditeUser
            // 
            this.cmsEditeUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetailsUser,
            this.tsmAddNewUser,
            this.TsmEditeUser,
            this.tsmDelete,
            this.tsmChangePassword});
            this.cmsEditeUser.Name = "cmsEdite";
            this.cmsEditeUser.Size = new System.Drawing.Size(181, 136);
            this.cmsEditeUser.Text = "Edite";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(801, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::DVLDFormLayer.Properties.Resources.Add_New_User_32;
            this.btnAddUser.Location = new System.Drawing.Point(840, 178);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(64, 39);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tsmShowDetailsUser
            // 
            this.tsmShowDetailsUser.Image = global::DVLDFormLayer.Properties.Resources.PersonDetails_32;
            this.tsmShowDetailsUser.Name = "tsmShowDetailsUser";
            this.tsmShowDetailsUser.Size = new System.Drawing.Size(165, 22);
            this.tsmShowDetailsUser.Text = "Show Details";
            this.tsmShowDetailsUser.Click += new System.EventHandler(this.tsmShowDetailsUser_Click);
            // 
            // tsmAddNewUser
            // 
            this.tsmAddNewUser.Image = global::DVLDFormLayer.Properties.Resources.AddPerson_32;
            this.tsmAddNewUser.Name = "tsmAddNewUser";
            this.tsmAddNewUser.Size = new System.Drawing.Size(165, 22);
            this.tsmAddNewUser.Text = "Add New User";
            this.tsmAddNewUser.Click += new System.EventHandler(this.tsmAddNewUser_Click);
            // 
            // TsmEditeUser
            // 
            this.TsmEditeUser.Image = global::DVLDFormLayer.Properties.Resources.edit_32;
            this.TsmEditeUser.Name = "TsmEditeUser";
            this.TsmEditeUser.Size = new System.Drawing.Size(165, 22);
            this.TsmEditeUser.Text = "Eddt";
            this.TsmEditeUser.Click += new System.EventHandler(this.TsmEditeUser_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::DVLDFormLayer.Properties.Resources.Delete_32;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::DVLDFormLayer.Properties.Resources.Password_32;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(165, 22);
            this.tsmChangePassword.Text = "ChangePassword";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 538);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.txtSerchUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.lblRecordUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilterUse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.cmsEditeUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblRecordUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtSerchUser;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsEditeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetailsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem TsmEditeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
    }
}