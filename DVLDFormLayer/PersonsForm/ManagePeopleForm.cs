using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBassnisLayer;
namespace DVLDFormLayer
{
    public partial class ManagePeopleForm : Form
    {
       
        public ManagePeopleForm()
        {
            InitializeComponent();
            settingComboBoxFilter();
            FilterDataPeople();
            
        }

       

        private void CloseForm()
        {
            this.Close();
        }

        private void settingComboBoxFilter()
        {
            cbFilter.SelectedIndex = 0;
            dgvPeople.Columns["ImagePath"].Visible = false;
            dgvPeople.Columns["Gendor"].Visible = false;
            dgvPeople.Columns["NationalityCountryID"].Visible = false;
        }
        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
       


        private void FilterDataPeople()
        {
            DataTable data = clsBassnisPersons.GetAllDataPersons();
            
            DataView dataView = data.DefaultView;
            string ValueFilter = cbFilter.SelectedItem.ToString();
            


            if (ValueFilter == "None")
            {
               
                dgvPeople.DataSource = dataView.ToTable();
                txtSearch.Visible=false;
            }
            else
            {
                if(cbFilter.SelectedItem.ToString() == "Gendor")
                {
                    ValueFilter = "GendorCaption";
                }
                if(cbFilter.SelectedItem.ToString() == "NationalityCountryID")
                {
                    ValueFilter = "CountryName";
                }
                txtSearch.Visible = true;
                dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{txtSearch.Text}%'";
                dgvPeople.DataSource = dataView.ToTable();
            }
           
            lblRecord.Text = dataView.Count.ToString();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataPeople();
        }

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDataPeople();
        }

        private void btnAddNewPeople_Click(object sender, EventArgs e)
        {
            
            AddEditPersonForm PAD = new AddEditPersonForm(-1);
            PAD.ShowDialog();
            FilterDataPeople();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AddEditPersonForm PAD = new AddEditPersonForm((int)dgvPeople.CurrentRow.Cells[0].Value);
            PAD.ShowDialog();
            FilterDataPeople();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            string PersonID = Convert.ToString((int)dgvPeople.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Do you Really Want To Delete This PersonID {PersonID}","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (clsBassnisPersons.DeletePersons((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfully");
                    FilterDataPeople();
                }
            }
        }

        private void cmsAddNew_Click(object sender, EventArgs e)
        {
            AddEditPersonForm PAD = new AddEditPersonForm(-1);
            PAD.ShowDialog();
            FilterDataPeople();
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            PersonDetailsForm details=new PersonDetailsForm((int)dgvPeople.CurrentRow.Cells[0].Value);
            details.ShowDialog();
            
        }
    }
}
