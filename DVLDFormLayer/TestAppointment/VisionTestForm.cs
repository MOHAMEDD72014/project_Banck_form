using DVLDBassnisLayer;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLDFormLayer.TestAppointment
{
    public partial class VisionTestForm : Form
    {
        int _LocalID;
        int countRowTest;
        bool IsLocked;
        int _typeTest;
        public VisionTestForm(int LocalID,int TypeTest)
        {
            InitializeComponent();

            _typeTest = TypeTest;
            _LocalID= LocalID;
            controlVisionTestInfo1.LocalID = _LocalID;
        }

        private void LoadListViewTestApintment()
        {
           // ListView listView = new ListView();
          DataTable dt = new DataTable();
            dt = clsBassnisTestAppointments.GetAllTestAppointments(_LocalID,_typeTest);
            DataView dataView=new DataView();
            IsLocked = false;
            if (dt.Rows.Count > 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                   
                        IsLocked = bool.Parse(dr["IsLocked"].ToString());
                      
                        dataView = dt.DefaultView;
                       
                    
                   
                }

               
                    dgvTestAppintment.DataSource = dataView.ToTable();
                    dgvTestAppintment.Columns["TestTypeID"].Visible = false;
                    dgvTestAppintment.Columns["CreatedByUserID"].Visible = false;
                    dgvTestAppintment.Columns["RetakeTestApplicationID"].Visible = false;
                    dgvTestAppintment.Columns["TestTypeID"].Visible = false;
                


            }
           
            
            dgvTestAppintment.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestAppintment.AllowUserToAddRows = false;
            countRowTest = dgvTestAppintment.RowCount;
            lblRecordApp.Text = countRowTest.ToString();
        }
        private void VisionTestForm_Load(object sender, EventArgs e)
        {
            LoadListViewTestApintment();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       

        private bool IsPassTest()
        {

            clsBassnisTestAppointments tes = clsBassnisTestAppointments.Find((int)dgvTestAppintment.CurrentRow.Cells[0].Value);
            clsBassnisTests test = clsBassnisTests.FindByTestAppointmentID(tes.TestAppointmentID);

           
                if ((tes.IsLocked == true && test.TestResult == false))
                {
                    tsmTakeTest.Enabled = false;
                return true;
                }else if (tes.IsLocked == false && test == null)
                {
                tsmTakeTest.Enabled = true;
                return true;
            }
                else if(tes.IsLocked == true && test.TestResult == true)
                {
                    tsmTakeTest.Enabled = false;
                return false;

                 }
                  else
                 {
                tsmTakeTest.Enabled = false;
               return false;
                   }
           
           
           
        }
        private void tsmTakeTest_Click(object sender, EventArgs e)
        {

            if (IsPassTest())
            {
                TakeTestForm Take = new TakeTestForm((int)dgvTestAppintment.CurrentRow.Cells[0].Value, _typeTest);
                Take.CountTest1 = dgvTestAppintment.RowCount;
                Take.ShowDialog();
            }
            controlVisionTestInfo1.LoadDataVisionTestInfo();
            LoadListViewTestApintment();
        }

        private void controlVisionTestInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmsEditeAppintMent_Opening(object sender, CancelEventArgs e)
        {
            IsPassTest();
        }

        private void TsmEditeTestAppintment_Click(object sender, EventArgs e)
        {
            int TempTestID = (int)dgvTestAppintment.CurrentRow.Cells[0].Value;

            clsBassnisTestAppointments tes = clsBassnisTestAppointments.FindbyLocalDrivingLicenseApplicationID(TempTestID);
            if (tes.IsLocked != true)
            {
                ScheduleTestForm schedule = new ScheduleTestForm(-1, _typeTest);
                schedule.AppintmentID = (int)dgvTestAppintment.CurrentRow.Cells[0].Value;
                schedule.CountTest = dgvTestAppintment.RowCount;
                schedule.IsActeve = true;
                schedule.ShowDialog();
            }
            else
            {
                ScheduleTestForm schedule = new ScheduleTestForm(-1, _typeTest);
                schedule.AppintmentID = (int)dgvTestAppintment.CurrentRow.Cells[0].Value;
                schedule.CountTest = dgvTestAppintment.RowCount;
                schedule.IsActeve = tes.IsLocked;
                schedule.ShowDialog();
            }

            LoadListViewTestApintment();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clsBassnisTestAppointments tes=new clsBassnisTestAppointments();
            clsBassnisTests test=new clsBassnisTests();
            if (dgvTestAppintment.Rows.Count > 0)
            {
                tes = clsBassnisTestAppointments.Find((int)dgvTestAppintment.CurrentRow.Cells[0].Value);
                test = clsBassnisTests.FindByTestAppointmentID(tes.TestAppointmentID);
            }
                if ((IsLocked == false && dgvTestAppintment.Rows.Count <= 0) || (IsLocked == true && dgvTestAppintment.Rows.Count > 0 && test.TestResult!=true))
                {

                    ScheduleTestForm schedule = new ScheduleTestForm(_LocalID, _typeTest);
                    schedule.CountTest = dgvTestAppintment.RowCount;
                    schedule.ShowDialog();

                }
                else if (tes.IsLocked == true && test.TestResult == true)
                {
                   MessageBox.Show("This Person Pass!!","Erorr",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
            LoadListViewTestApintment();
        }
    }
}
