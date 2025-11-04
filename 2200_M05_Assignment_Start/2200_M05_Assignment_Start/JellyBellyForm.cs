using _2200_M05_Assignment_Start.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_M05_Assignment_Start
{
    public partial class JellyBellyForm : Form
    {
        JBModel db = new JBModel();

        public JellyBellyForm()
        {
            InitializeComponent();
        }
        

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<JellyBelly> jellyBellies = (from prod in db.JellyBellies
                                             select prod).ToList();
            dgvFlavorCategory.DataSource = jellyBellies;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<JellyBelly> jellyBellies = (from prod in db.JellyBellies
                                             where prod.jellyBellyFlavor.Contains(txtSearch.Text)
                                             select prod).ToList();
            dgvFlavorCategory.DataSource= jellyBellies;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JellyBellyForm_Load_1(object sender, EventArgs e)
        {
            // LINQ spelled out
            List<JellyBelly> jellyBellies = (from prod in db.JellyBellies
                                             select prod).ToList();
            // LINQ method
            //List<Product> linqMethod = db.Products.ToList();
            // assign values to data grid view
            //dgvFlavorCategory.DataSource = products;

            dgvFlavorCategory.DataSource = jellyBellies;
            dgvFlavorCategory.Columns[0].Visible = false;
            dgvFlavorCategory.Columns[1].HeaderCell.Value = "Flavor";
            dgvFlavorCategory.Columns[2].Width = 200;
            dgvFlavorCategory.Columns[2].HeaderCell.Value = "Flavor Category";
        }
    }
}
