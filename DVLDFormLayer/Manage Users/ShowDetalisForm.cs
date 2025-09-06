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
    public partial class ShowDetalisForm : Form
    {

        int _TempUserID;
        int _TempPersonID;
        public ShowDetalisForm(int UserID,int PersonID)
        {
            InitializeComponent();
            _TempUserID = UserID;
            _TempPersonID = PersonID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDatalse()
        {
            personInformation1.PersonID = _TempPersonID;
            personInformation1.LoadInformationPerson();
            userCuntrolInformatinUser1.UserID= _TempUserID;
            userCuntrolInformatinUser1.LoginInformation();
        }
        private void ShowDetalisForm_Load(object sender, EventArgs e)
        {
            ShowDatalse();
        }

        private void userCuntrolInformatinUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
