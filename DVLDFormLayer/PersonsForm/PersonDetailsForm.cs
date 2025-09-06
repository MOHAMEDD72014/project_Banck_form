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
    public partial class PersonDetailsForm : Form
    {

        public PersonDetailsForm(int PersonID)
        {
            InitializeComponent();
            UserControlDetails.PersonID = PersonID;
        }
        public PersonDetailsForm(string NationalNo)
        {
            InitializeComponent();
           clsBassnisPersons person= clsBassnisPersons.Find(NationalNo);
            UserControlDetails.PersonID = person.PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void PersonDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void UserControlDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
