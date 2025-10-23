using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_BarclayE_Participation04
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalPhoneNumbers_Click(object sender, EventArgs e)
        {
            LocalPhoneNumbersForm localPhoneForm = new LocalPhoneNumbersForm();
            localPhoneForm.ShowDialog();
        }

        private void btnImportedPhoneNumbers_Click(object sender, EventArgs e)
        {
            UVUPhoneListForm uvuPhoneForm = new UVUPhoneListForm();
            uvuPhoneForm.ShowDialog();
        }
    }
}
