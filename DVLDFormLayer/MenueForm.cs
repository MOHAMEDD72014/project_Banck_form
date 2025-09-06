using DVLDBassnisLayer;
using DVLDFormLayer;
using DVLDFormLayer.International;
using DVLDFormLayer.LicenseDrive;
using DVLDFormLayer.Local_Driving;
using DVLDFormLayer.Login;
using DVLDFormLayer.Manage_Users;
using DVLDFormLayer.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer
{
    public partial class MenueForm : Form
    {
        public MenueForm()
        {
            InitializeComponent();
        }

        private void MenuPeople_Click(object sender, EventArgs e)
        {
            ManagePeopleForm MPF= new ManagePeopleForm();
            MPF.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            ManageUsersForm MUF = new ManageUsersForm();
            MUF.ShowDialog();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            clsBassnisGlobal.CurrentUser =clsBassnisUsers.FindByUserAndPassword("","");
            LoginForm lg=new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void currentUserInfo_Click(object sender, EventArgs e)
        {
            ShowDetalisForm fr = new ShowDetalisForm(clsBassnisGlobal.CurrentUser.UsersID,clsBassnisGlobal.CurrentUser.PersonID);
            fr.ShowDialog();
        }

        private void changePassWord_Click(object sender, EventArgs e)
        {
            ChengePasswordForm ch = new ChengePasswordForm(clsBassnisGlobal.CurrentUser.UsersID, clsBassnisGlobal.CurrentUser.PersonID);
            ch.ShowDialog();
        }

        private void mangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes types= new ManageApplicationTypes();
            types.ShowDialog();

        }

        private void mangeTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTyps testTyps= new ManageTestTyps();
            testTyps.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingForm newLocal= new NewLocalDrivingForm();
            newLocal.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingForm local= new ManageLocalDrivingForm();
            local.ShowDialog();
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            DriversForm drivers= new DriversForm();
            drivers.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InternationalAppliction international= new InternationalAppliction();
            international.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangerInternatinalForm intern=new MangerInternatinalForm();
            intern.ShowDialog();
        }
    }
}
