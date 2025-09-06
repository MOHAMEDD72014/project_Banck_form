namespace DVLDFormLayer.Manage_Users
{
    partial class AddNewUserForm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPersnalInfo = new System.Windows.Forms.TabPage();
            this.filterAndInformationPerson1 = new DVLDFormLayer.UserControls.FilterAndInformationPerson();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl2.SuspendLayout();
            this.tabPersnalInfo.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPersnalInfo);
            this.tabControl2.Controls.Add(this.tabLoginInfo);
            this.tabControl2.Location = new System.Drawing.Point(0, 63);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(861, 372);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPersnalInfo
            // 
            this.tabPersnalInfo.Controls.Add(this.button1);
            this.tabPersnalInfo.Controls.Add(this.filterAndInformationPerson1);
            this.tabPersnalInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPersnalInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersnalInfo.Name = "tabPersnalInfo";
            this.tabPersnalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersnalInfo.Size = new System.Drawing.Size(853, 346);
            this.tabPersnalInfo.TabIndex = 0;
            this.tabPersnalInfo.Text = "Personal Info";
            this.tabPersnalInfo.UseVisualStyleBackColor = true;
            // 
            // filterAndInformationPerson1
            // 
            this.filterAndInformationPerson1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAndInformationPerson1.Location = new System.Drawing.Point(1, 6);
            this.filterAndInformationPerson1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filterAndInformationPerson1.Name = "filterAndInformationPerson1";
            this.filterAndInformationPerson1.NatonalNo = null;
            this.filterAndInformationPerson1.PersonID = 0;
            this.filterAndInformationPerson1.Size = new System.Drawing.Size(852, 296);
            this.filterAndInformationPerson1.TabIndex = 0;
            this.filterAndInformationPerson1.OnSavePerson += new System.Action<int>(this.filterAndInformationPerson1_OnSavePerson);
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.chIsActive);
            this.tabLoginInfo.Controls.Add(this.txtConPass);
            this.tabLoginInfo.Controls.Add(this.txtPassword);
            this.tabLoginInfo.Controls.Add(this.txtUseName);
            this.tabLoginInfo.Controls.Add(this.lblUserID);
            this.tabLoginInfo.Controls.Add(this.label8);
            this.tabLoginInfo.Controls.Add(this.label6);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Controls.Add(this.pictureBox5);
            this.tabLoginInfo.Controls.Add(this.pictureBox4);
            this.tabLoginInfo.Controls.Add(this.pictureBox3);
            this.tabLoginInfo.Controls.Add(this.pictureBox1);
            this.tabLoginInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(853, 346);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Login Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(238, 244);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(76, 17);
            this.chIsActive.TabIndex = 178;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(238, 190);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(160, 21);
            this.txtConPass.TabIndex = 177;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(238, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 21);
            this.txtPassword.TabIndex = 176;
            // 
            // txtUseName
            // 
            this.txtUseName.Location = new System.Drawing.Point(238, 97);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(160, 21);
            this.txtUseName.TabIndex = 175;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(235, 57);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(25, 13);
            this.lblUserID.TabIndex = 173;
            this.lblUserID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 172;
            this.label8.Text = "UserID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 169;
            this.label6.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 163;
            this.label2.Text = "Confirm Password:";
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewUser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAddNewUser.Location = new System.Drawing.Point(317, 19);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(179, 41);
            this.lblAddNewUser.TabIndex = 111;
            this.lblAddNewUser.Text = "Add New User";
            this.lblAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDFormLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(743, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDFormLayer.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(621, 469);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 109;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLDFormLayer.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(739, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 111;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::DVLDFormLayer.Properties.Resources.Number_321;
            this.pictureBox5.Location = new System.Drawing.Point(184, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 174;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::DVLDFormLayer.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(184, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 171;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::DVLDFormLayer.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(184, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 168;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLDFormLayer.Properties.Resources.Number_321;
            this.pictureBox1.Location = new System.Drawing.Point(184, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 555);
            this.Controls.Add(this.lblAddNewUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl2);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPersnalInfo.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.FilterAndInformationPerson filterAndInformationPerson1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPersnalInfo;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUseName;
    }
}