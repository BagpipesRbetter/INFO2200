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

    public partial class CategoryForm : Form
    {
        JBModel db = new JBModel();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            lvCategory.Columns.Add("Category");
            lvCategory.Columns.Add("Number");

            var jbCat2 = from j in db.JellyBellies
                         group j by j.category into x
                         orderby x.Count() descending
                         select x;
            foreach (IGrouping<String, JellyBelly> ct in jbCat2)
            {
                String[] listValues = { ct.Key, ct.Count().ToString() };
                ListViewItem lvi = new ListViewItem(listValues);
                lvCategory.Items.Add(lvi);
            }
            lvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }



        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
