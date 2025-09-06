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

namespace DVLDFormLayer
{
    public partial class UpdateApplicationType : Form
    {
        int _typeID;
        clsBassnisApplicationTypes Types;
        public UpdateApplicationType(int TypeID)
        {
            InitializeComponent();
            _typeID = TypeID;
        }

        private void EditeTypeAndLoadeData()
        {
            Types = clsBassnisApplicationTypes.Find(_typeID);
            if (Types != null)
            {
                txtTitle.Enabled = false;   
                lblIDType.Text = Types.ApplicationTypeID.ToString();
                txtTitle.Text= Types.ApplicationTypeTitle;
                txtFees.Text = Types.ApplicationFees.ToString();
               
                
            }
        }
        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            EditeTypeAndLoadeData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Types.ApplicationFees = double.Parse(txtFees.Text);
            if (MessageBox.Show("Do you Wint Edit fees ?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Types.Save())
                {
                    MessageBox.Show("Edit Secssfoly");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not Save Secssfoly");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
