using DVLDBassnisLayer;
using DVLDFormLayer.UserControls;
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
    public partial class ChengePasswordForm : Form
    {
        int _TempUserID;
        int _TempPersonID;
        public ChengePasswordForm(int UserID,int PersonID)
        {
            InitializeComponent();
            _TempUserID = UserID;
            _TempPersonID = PersonID;
        }

        private void ChingePassword()
        {
            clsBassnisUsers users = clsBassnisUsers.Find(_TempUserID);
            if (users != null)
            {
                if (txtCurrentPassword.Text == users.Password)
                {
                    if (txtPassword.Text == txtConPassword.Text)
                    {
                        users.Password = txtPassword.Text;
                        if (users.Save())
                        {
                            MessageBox.Show("Pasword Change Password Secssfoly");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwor Not Match");
                    }
                }
                else
                {
                    MessageBox.Show("Pasword not Carcte Plase Try Agine");
                }
            }


        }
        private void ChengePasswordForm_Load(object sender, EventArgs e)
        {
            personInformation1.Tag = _TempPersonID;
            personInformation1.LoadInformationPerson();
            userCuntrolInformatinUser1.UserID = _TempUserID;
            userCuntrolInformatinUser1.LoginInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChingePassword();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
