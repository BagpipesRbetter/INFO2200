using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovieCount : Form
    {
        public MovieCount()
        {
            InitializeComponent();
        }

        private void MovieCount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSetCount.CategoryCount' table. You can move, or remove it, as needed.
            this.categoryCountTableAdapter.Fill(this.iNFO2200_CrandallSayDataSetCount.CategoryCount);

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
