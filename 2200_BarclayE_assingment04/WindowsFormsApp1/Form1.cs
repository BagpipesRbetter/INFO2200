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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.Movie);

        }

        private void SortAZbtn_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortAZ(this.iNFO2200_CrandallSayDataSet.Movie);

        }

        private void SortZAbtn_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortZA(this.iNFO2200_CrandallSayDataSet.Movie);
        }

        private void Search20btn_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SearchFirst20Byid(this.iNFO2200_CrandallSayDataSet.Movie, textBox1.Text);
        }

        private void DisplayMvCoubtn_Click(object sender, EventArgs e)
        {
            MovieCount movieCountForm = new MovieCount();
            movieCountForm.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Search(this.iNFO2200_CrandallSayDataSet.Movie, textBox1.Text);
        }
    }
}
