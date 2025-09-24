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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for PhoneDetailsWindow.xaml
    /// </summary>
    public partial class PhoneDetailsWindow : Window
    {
        public PhoneDetailsWindow()
        {
            InitializeComponent();
        }

        public void UpdateGUI(Phone phone)
        {
            lblMake.Content = phone.make;
            lblModel.Content = phone.model;
            lblDisplay.Content = phone.display;
            lblStorage.Content = phone.storage;
            lblPrice.Content = phone.price.ToString("c");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
