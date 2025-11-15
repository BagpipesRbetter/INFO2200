using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_M05_Participation_Start
{
    public partial class CategoryForm : Form
    {
        ProductEntityDb db = new ProductEntityDb();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LvCategories.Columns.Add("Category");
            LvCategories.Columns.Add("Count");
            List<CategoryTotalViewModel> categoryTotals = (from cat in db.Products
                                                           group cat.Category by cat.Category into cats
                                                           select new CategoryTotalViewModel { ProdCategory = cats.Key, CatCount = cats.Count() }).ToList();
            foreach (CategoryTotalViewModel item in categoryTotals)
            {
                string[] listitems = { item.ProdCategory, item.CatCount.ToString() };
                ListViewItem lvi = new ListViewItem(listitems);
                LvCategories.Items.Add(lvi);
            }
            LvCategories.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
    public class CategoryTotalViewModel
    {
        public string ProdCategory { get; set; }
        public int CatCount { get; set; }
    }
}
