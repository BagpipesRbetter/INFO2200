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
    public partial class LocalPhoneNumbersForm : Form
    {
        public LocalPhoneNumbersForm()
        {
            InitializeComponent();
        }

        private void phoneListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localPhoneListDBDataSet);

        }

        private void LocalPhoneNumbersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneListDBDataSet.PhoneList' table. You can move, or remove it, as needed.
            this.phoneListTableAdapter.Fill(this.localPhoneListDBDataSet.PhoneList);

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            this.phoneListTableAdapter.FillByFirstNameSearch(this.localPhoneListDBDataSet.PhoneList, textBox1.Text);
        }
    }
}
