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

        }
    }
}
