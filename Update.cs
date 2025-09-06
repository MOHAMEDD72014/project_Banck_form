using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Banck_form
{
    public partial class Update : Form
    {
        
        public string AcuntNumber { get; set; }
        public string NameClinte1 { get; set; }
        public string PinNumber { get; set; }
        public string  phone{ get; set; }
        public string AcuntBlunce { get; set; }

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            AcuntNumber = txAcuntNumberUP.Text;
            NameClinte1 = txNameUP.Text;
            PinNumber = txPinUP.Text;
            phone=txPhoneUP.Text;
            AcuntBlunce=txAcuntBalanceUP.Text;

           
            this.Hide();
        }
    }
}
