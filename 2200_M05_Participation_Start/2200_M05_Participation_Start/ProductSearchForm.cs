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
    public partial class ProductSearchForm : Form
    {
        // create connection to database
        ProductEntityDb db = new ProductEntityDb();

        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            List<Product> products = (from prod in db.Products
                                      select prod).ToList();
            DgvProducts.DataSource = products;
            CbProductId.Items.AddRange(products.Select(p => p.Product_Number).ToArray());
        }

        private void BtnAddNewProd_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            List<Product> products = (from prod in db.Products
                                      select prod).ToList();
            DgvProducts.DataSource = products;
        }

        private void BtnDeleteProd_Click(object sender, EventArgs e)
        {
            Product findproduct = db.Products.FirstOrDefault(p => p.Product_Number == CbProductId.SelectedItem.ToString());
            if (findproduct != null)
            {
                db.Products.Remove(findproduct);
                db.SaveChanges();
                MessageBox.Show($"{findproduct.Product_Number} was deleted");
                List<Product> products = (from prod in db.Products
                                          select prod).ToList();
                DgvProducts.DataSource = products;
                CbProductId.Items.Clear();
                CbProductId.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
            }
            else
            {
                MessageBox.Show($"{CbProductId.SelectedItem} not found");
            }
        }

        private void TxtBoxProductDesc_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = (from prod in db.Products
                                      where prod.Description.Contains(TxtBoxProductDesc.Text)
                                      select prod).ToList();
            DgvProducts.DataSource = products;
        }
    }
}
