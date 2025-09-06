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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            cbFilterUse.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            
        }
        private void FilterDataUser()
        {
            DataTable data = clsBassnisUsers.GetAllDataUsers();
            
            DataView dataView = data.DefaultView;
            ComboBoxFilterUser();

            string ValueFilter = cbFilterUse.SelectedItem.ToString();

            if (ValueFilter == "None"|| ValueFilter == "IsActive")
            {
               
                string stauts;
                txtSerchUser.Visible = false;
                dgvUser.DataSource = dataView.ToTable();
                if (cbIsActive.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    if (cbIsActive.SelectedItem.ToString() != "All")
                    {

                        if (cbIsActive.SelectedItem.ToString() == "Yes")
                        {
                            stauts = "true";
                        }
                        else
                        {
                            stauts = "false";
                        }
                        dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{stauts}%'";
                        dgvUser.DataSource = dataView.ToTable();
                    }
                    else
                    {

                        dgvUser.DataSource = dataView.ToTable();
                    }

                }

            }
            else
            {
               
                txtSerchUser.Visible = true;
                dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{txtSerchUser.Text}%'";
                dgvUser.DataSource = dataView.ToTable();
            }

            lblRecordUser.Text = dataView.Count.ToString();
        }
      
        private void ComboBoxFilterUser()
        {

            
            if (cbFilterUse.SelectedItem.ToString() == "IsActive")
            {
               
                cbIsActive.Visible = true;
            }
            else
            {
                cbIsActive.Visible = false;
            }
         
        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            
            FilterDataUser();

        }

        private void cbFilterUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FilterDataUser();
        }

        private void txtSerchUser_TextChanged(object sender, EventArgs e)
        {
            FilterDataUser();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm Add = new AddNewUserForm(-1,-1);
            Add.ShowDialog();
            FilterDataUser();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            ChengePasswordForm chenge=new ChengePasswordForm((int)dgvUser.CurrentRow.Cells[0].Value, (int)dgvUser.CurrentRow.Cells[1].Value);
            chenge.ShowDialog();
            FilterDataUser(); 
        }

        private void TsmEditeUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm add = new AddNewUserForm((int)dgvUser.CurrentRow.Cells[0].Value, (int)dgvUser.CurrentRow.Cells[1].Value);
            add.LoadDataUsers();
            add.ShowDialog();

            FilterDataUser();
        }

        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm Add = new AddNewUserForm(-1, (int)dgvUser.CurrentRow.Cells[1].Value);
            Add.ShowDialog();
            FilterDataUser();
        }

        private void tsmShowDetailsUser_Click(object sender, EventArgs e)
        {
            ShowDetalisForm Show = new ShowDetalisForm((int)dgvUser.CurrentRow.Cells[0].Value, (int)dgvUser.CurrentRow.Cells[1].Value);
            Show.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (clsBassnisUsers.DeleteUsers((int)dgvUser.CurrentRow.Cells[0].Value))
            {
               if( MessageBox.Show("You Need Delete This User","Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Deleted Seccssfly");
                }
                else
                {
                    MessageBox.Show("Not Deleted Seccssfly");
                }
            }
            FilterDataUser();
        }
    }
}
