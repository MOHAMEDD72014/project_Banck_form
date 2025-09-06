using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.Manage_Users
{
    public partial class AddNewUserForm : Form
    {
        int _PersonID;
        int _UserID;
        clsBassnisUsers _User;
        public AddNewUserForm(int UserID, int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _UserID = UserID;
        }
        public void AddNewUser()
        {
          
            filterAndInformationPerson1.FilterSearchPerson();
            _PersonID = filterAndInformationPerson1.PersonID;
            _User =new clsBassnisUsers();   
            _User.PersonID=  _PersonID;
            _User.UserName = txtUseName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive=chIsActive.Checked;
            if (_User.Save())
            {
                lblAddNewUser.Text = "Update User";
                lblUserID.Text = _User.UsersID.ToString();
                MessageBox.Show("User Add User Secssfoly");
            }
            else
            {
                MessageBox.Show("User Not Add");
            }
        }


        public void LoadDataUsers()
        {
            filterAndInformationPerson1.FilterIsNotActive();
            lblAddNewUser.Text = "Update User";
            filterAndInformationPerson1.PersonID = _PersonID;
            filterAndInformationPerson1.FilterSearchPerson();
            lblUserID.Text = _UserID.ToString();
            _User = clsBassnisUsers.Find(_UserID);
            if (_User!=null)
            {
                _User.UserName = txtUseName.Text;
                if (txtPassword.Text == txtConPass.Text)
                {
                    _User.Password = txtPassword.Text;
                }
                else
                {
                    MessageBox.Show("Password Erorr");
                }

                _User.IsActive = chIsActive.Checked;
            }

        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabLoginInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void filterAndInformationPerson1_OnSavePerson(int obj)
        {
            _PersonID = obj;
            filterAndInformationPerson1.LoadInformtionPerson(obj);
           
        
    }
    }
}
