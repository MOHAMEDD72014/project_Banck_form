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
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void LoadApplicationTypes()
        {
            DataTable data = clsBassnisApplicationTypes.GetAllApplicationTypes();

            DataView dataView = data.DefaultView;

            dgvManageApplicationTypes.DataSource = dataView.ToTable();
            lblRecordMAT.Text = dataView.Count.ToString();

        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edite_Click(object sender, EventArgs e)
        {
            UpdateApplicationType Updat=new UpdateApplicationType((int)dgvManageApplicationTypes.CurrentRow.Cells[0].Value);
            Updat.ShowDialog();
            LoadApplicationTypes();
        }
    }
}
