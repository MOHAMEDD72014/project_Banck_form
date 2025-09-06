namespace DVLDFormLayer
{
    partial class MenueForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.Drivers = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.accuontSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.MenuPeople,
            this.Drivers,
            this.Users,
            this.accuontSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.mangToolStripMenuItem,
            this.mangeTestTypesToolStripMenuItem});
            this.Applications.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applications.Image = global::DVLDFormLayer.Properties.Resources.Application_Types_64;
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(129, 36);
            this.Applications.Text = "Appilcations";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.LocalDriving_License;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.drivingLicensesServicesToolStripMenuItem.Text = "driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem1});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.Local_32;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem1
            // 
            this.internationalLicenseApplicationToolStripMenuItem1.Image = global::DVLDFormLayer.Properties.Resources.International_323;
            this.internationalLicenseApplicationToolStripMenuItem1.Name = "internationalLicenseApplicationToolStripMenuItem1";
            this.internationalLicenseApplicationToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.internationalLicenseApplicationToolStripMenuItem1.Text = "International License Application";
            this.internationalLicenseApplicationToolStripMenuItem1.Click += new System.EventHandler(this.internationalLicenseApplicationToolStripMenuItem1_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationsToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.Manage_Applications_32;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.LocalDriving_License1;
            this.localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            this.localDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Application";
            this.localDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.International_32;
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            this.internationalLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainLicensesToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.Detain_32;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // mangToolStripMenuItem
            // 
            this.mangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.Application_Types_641;
            this.mangToolStripMenuItem.Name = "mangToolStripMenuItem";
            this.mangToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.mangToolStripMenuItem.Text = "Manage Application Types";
            this.mangToolStripMenuItem.Click += new System.EventHandler(this.mangToolStripMenuItem_Click);
            // 
            // mangeTestTypesToolStripMenuItem
            // 
            this.mangeTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeTestTypesToolStripMenuItem.Image = global::DVLDFormLayer.Properties.Resources.Schedule_Test_32;
            this.mangeTestTypesToolStripMenuItem.Name = "mangeTestTypesToolStripMenuItem";
            this.mangeTestTypesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.mangeTestTypesToolStripMenuItem.Text = "Mange Test Types";
            this.mangeTestTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeTestTypesToolStripMenuItem_Click);
            // 
            // MenuPeople
            // 
            this.MenuPeople.AutoSize = false;
            this.MenuPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuPeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPeople.Image = global::DVLDFormLayer.Properties.Resources.People_400;
            this.MenuPeople.Name = "MenuPeople";
            this.MenuPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuPeople.Size = new System.Drawing.Size(94, 36);
            this.MenuPeople.Text = "People";
            this.MenuPeople.Click += new System.EventHandler(this.MenuPeople_Click);
            // 
            // Drivers
            // 
            this.Drivers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drivers.Image = global::DVLDFormLayer.Properties.Resources.Drivers_64;
            this.Drivers.Name = "Drivers";
            this.Drivers.Size = new System.Drawing.Size(96, 36);
            this.Drivers.Text = "Drivers";
            this.Drivers.Click += new System.EventHandler(this.Drivers_Click);
            // 
            // Users
            // 
            this.Users.AutoSize = false;
            this.Users.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Image = global::DVLDFormLayer.Properties.Resources.Users_2_64;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(94, 36);
            this.Users.Text = "Users";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // accuontSettings
            // 
            this.accuontSettings.AutoSize = false;
            this.accuontSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfo,
            this.changePassWord,
            this.signOut});
            this.accuontSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuontSettings.Image = global::DVLDFormLayer.Properties.Resources.account_settings_64;
            this.accuontSettings.Name = "accuontSettings";
            this.accuontSettings.Size = new System.Drawing.Size(160, 36);
            this.accuontSettings.Text = "Accuont Settings";
            // 
            // currentUserInfo
            // 
            this.currentUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserInfo.Image = global::DVLDFormLayer.Properties.Resources.PersonDetails_321;
            this.currentUserInfo.Name = "currentUserInfo";
            this.currentUserInfo.Size = new System.Drawing.Size(173, 22);
            this.currentUserInfo.Text = "Current User Info";
            this.currentUserInfo.Click += new System.EventHandler(this.currentUserInfo_Click);
            // 
            // changePassWord
            // 
            this.changePassWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassWord.Image = global::DVLDFormLayer.Properties.Resources.Password_32;
            this.changePassWord.Name = "changePassWord";
            this.changePassWord.Size = new System.Drawing.Size(173, 22);
            this.changePassWord.Text = "Change PassWord";
            this.changePassWord.Click += new System.EventHandler(this.changePassWord_Click);
            // 
            // signOut
            // 
            this.signOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.Image = global::DVLDFormLayer.Properties.Resources.sign_out_32__2;
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(173, 22);
            this.signOut.Text = "Sign Out";
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // MenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DVLDFormLayer.Properties.Resources.IconLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenueForm";
            this.Text = "DVLD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuPeople;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem accuontSettings;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem changePassWord;
        private System.Windows.Forms.ToolStripMenuItem signOut;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Drivers;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem1;
    }
}

