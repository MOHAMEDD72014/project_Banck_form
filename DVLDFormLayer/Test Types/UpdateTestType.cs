using DVLDBassnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDFormLayer.Test_Types
{
    public partial class UpdateTestType : Form
    {
        int _typeID;
        clsBassnisTestTypes Types;
        public UpdateTestType(int TypeID)
        {
            InitializeComponent();
            _typeID = TypeID;
        }
        private void EditeTypeAndLoadeData()
        {
            Types = clsBassnisTestTypes.Find(_typeID);
            if (Types != null)
            {
                
                lblIDType.Text = Types.TestTypeID.ToString();
                txtTitle.Text = Types.TestTypeTitle;
                txtDescription.Text= Types.TestTypeDescription;
                txtFees.Text = Types.TestTypeFees.ToString();


            }
        }
        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            EditeTypeAndLoadeData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Types.TestTypeTitle = txtTitle.Text;
            Types.TestTypeDescription = txtDescription.Text;
            Types.TestTypeFees = double.Parse(txtFees.Text);
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

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
