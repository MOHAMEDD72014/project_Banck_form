using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.Login
{
    public partial class LoginForm : Form
    {
       
        static string FileRemeberMe = @"C:\Users\Mohamed\source\repos\DVLDBassnisLayer\RememberMeUser";
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool Login(string UserName,string Password)
        {
            clsBassnisGlobal.CurrentUser=clsBassnisUsers.FindByUserAndPassword(UserName, Password);
            if (clsBassnisGlobal.CurrentUser != null && 
                clsBassnisGlobal.CurrentUser.UserName == 
                UserName && clsBassnisGlobal.CurrentUser.Password == Password)
            {
                if (clsBassnisGlobal.CurrentUser.IsActive)
                {
                    ChickRemberMe();
                    return true;
                }
                else
                {
                    MessageBox.Show("User Is Not Actvit Please Tell Admin!!","Admin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Password And User Name Is Encrect Plaese Tray Agin", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtUserName.Text, txtPassword.Text))
            {
                MenueForm Men=new MenueForm();
                Men.Show();
                this.Hide();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChickRemberMe()
        {
            clsFileRemberMe re = new clsFileRemberMe();
            if (checkBox1.Checked)
            {
                
                re.UserName = txtUserName.Text;
                re.Password = txtPassword.Text;
                re.IsActve = true;
                clsFileRemberMe.AddNewClientToFile(clsFileRemberMe.joinString(re));

            }
            else
            {
                re.UserName = "";
                re.Password = "";
                re.IsActve=false;
                clsFileRemberMe.AddNewClientToFile(clsFileRemberMe.joinString(re));

            }
        }


        private void LoginRemberMe()
        {
            List<clsFileRemberMe> Files=new List<clsFileRemberMe>();
            Files = clsFileRemberMe.LoadClientDataFromFile();
            foreach(clsFileRemberMe i in Files)
            {
                txtUserName.Text = i.UserName;
                txtPassword.Text = i.Password;
                checkBox1.Checked = i.IsActve;
                return;
            }
            return;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginRemberMe();
        }
    }
}
