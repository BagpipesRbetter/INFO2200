using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        // create a Dictionary where the key is a string and the value is an object of the Phone class

        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();

        public MainWindow()
        {
            InitializeComponent();

            // call to the method

            LoadPhoneDetails();
        }

        /// <summary>
        /// Explain the LoadPhoneDetails method
        /// </summary>
        private void LoadPhoneDetails()
        {
            StreamReader inputFile;
            //const string PHONES_FILE = "phones.txt"; // not required
            string[] tempPhone;
            //
            try
            {   //
                inputFile = File.OpenText("phones.txt");
                // inputFile = File.OpenText(PHONES_FILE); not required
                inputFile.ReadLine();
                while (!inputFile.EndOfStream)
                {
                    //
                    tempPhone = inputFile.ReadLine().Split(',');
                    //
                    cboPhones.Items.Add(tempPhone[0]);
                    //
                    phoneDict.Add(tempPhone[0], new Phone(tempPhone));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Explain the btnPhoneDetails Click Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPhoneDetails_Click(object sender, RoutedEventArgs e)
        {
            PhoneDetailsWindow pdw = new PhoneDetailsWindow();

            string key = cboPhones.SelectedItem.ToString();

            Phone phone;

            if (phoneDict.TryGetValue(key, out phone))
            {
                //pdw.lblDisplay.Content = phone.DisplaySize; // not required

                pdw.UpdateGUI(phone);
                pdw.Show();
            }
            else
            {
                MessageBox.Show($"Could not find {key} in the database.");
            }
        }
    }
}