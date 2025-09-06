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

namespace DVLDFormLayer.Test_Types
{
    public partial class ManageTestTyps : Form
    {
        public ManageTestTyps()
        {
            InitializeComponent();
        }
        private void LoadTestTypes()
        {
            DataTable data = clsBassnisTestTypes.GetAllTestTypes();

            DataView dataView = data.DefaultView;

            dgvManageTestTypes.DataSource = dataView.ToTable();
            lblRecordMAT.Text = dataView.Count.ToString();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageTestTyps_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }

        private void Edite_Click(object sender, EventArgs e)
        {
            UpdateTestType updateTest = new UpdateTestType((int)dgvManageTestTypes.CurrentRow.Cells[0].Value);
            updateTest.ShowDialog();
            LoadTestTypes();
        }
    }
}
