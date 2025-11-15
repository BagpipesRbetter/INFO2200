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
    public partial class AddProductForm : Form
    {
        ProductEntityDb db = new ProductEntityDb();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CbCategory.Items.Add("New Category");
            var catItems = from cat in db.Products
                           where cat.Category != null
                           group cat.Category by cat.Category into c
                           select new { Category = c.Key };
            CbCategory.Items.AddRange(catItems.Select(c => c.Category).ToArray());
            
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCategory.SelectedIndex == 0)
            {
                TxtBoxNewCategory.Show();
                label6.Show();
            }
            else
            {
                TxtBoxNewCategory.Hide();
                label6.Hide();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            decimal price;
            int uoh;
            string category;

            if (TxtBoxDesc.Text.Trim() != "" && decimal.TryParse(TxtBoxPrice.Text, out price) && int.TryParse(TxtBoxUoH.Text, out uoh) && CbCategory.SelectedIndex > -1)
            {
                Product newprod = new Product
                {
                    Category = CbCategory.SelectedIndex == 0 ? TxtBoxNewCategory.Text.Trim() : CbCategory.SelectedItem.ToString(),
                    Description = TxtBoxDesc.Text.Trim(),
                    Price = price,
                    Units_On_Hand = uoh,
                    Product_Number = TxtBoxProdNum.Text.Trim()
                };
                db.Products.Add(newprod);
                db.SaveChanges();
                MessageBox.Show($"{newprod.Product_Number} added.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Please check your entries and try again.");
            }
        }
    }
}
