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

namespace DVLDFormLayer.UserControls
{
    public partial class UserCuntrolInformatinUser : UserControl
    {
        public int UserID {  get; set; }
        public UserCuntrolInformatinUser()
        {
            InitializeComponent();
        }

        public void LoginInformation()
        {
           // int TempUserID=Convert.ToInt32(UserID);
            clsBassnisUsers User = clsBassnisUsers.Find(UserID);
            if (User != null)
            {
                lblUserID.Text = UserID.ToString();
                lblUserName.Text = User.UserName;
                lblIsActive.Text = User.IsActive.ToString();

            }
            else
            {
                MessageBox.Show("Errer");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserCuntrolInformatinUser_Load(object sender, EventArgs e)
        {

        }
    }
}
