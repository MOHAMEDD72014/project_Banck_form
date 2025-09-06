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

namespace DVLDFormLayer.LicenseDrive
{
    public partial class DriversForm : Form
    {
        public DriversForm()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FilterDataDrivers()
        {
            DataTable data = clsBassnisDrivers.GetAllDriversVeiw();

            DataView dataView = data.DefaultView;
            string ValueFilter = cbFilter.SelectedItem.ToString();



            if (ValueFilter == "None")
            {

                dgvDrivers.DataSource = dataView.ToTable();
                txtSearch.Visible = false;
            }
            else
            {
               
                txtSearch.Visible = true;
                dataView.RowFilter = $"CONVERT({ValueFilter},'System.String') LIKE '%{txtSearch.Text}%'";
                dgvDrivers.DataSource = dataView.ToTable();
            }

            lblRecord.Text = dataView.Count.ToString();
        }
        private void DriversForm_Load(object sender, EventArgs e)
        {
            FilterDataDrivers();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataDrivers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDataDrivers();
        }
    }
}
