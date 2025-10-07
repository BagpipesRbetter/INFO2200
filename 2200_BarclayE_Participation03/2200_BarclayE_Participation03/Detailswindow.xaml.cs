using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2200_BarclayE_Participation03
{
    /// <summary>
    /// Interaction logic for Detailswindow.xaml
    /// </summary>
    public partial class Detailswindow : Window
    {
        public Plant SelectedPlant { get; set; }
        public Detailswindow()
        {
            InitializeComponent();
        }

        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(SelectedPlant.Sniff());
        }
    }
}

