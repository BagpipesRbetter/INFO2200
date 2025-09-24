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
   
    public partial class MainWindow : Window
    {
        

        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();

        public MainWindow()
        {
            InitializeComponent();

            LoadPhoneDetails();
        }

        private void LoadPhoneDetails()
        {
            StreamReader inputFile;
            
            string[] tempPhone;
           
            try
            {   
                inputFile = File.OpenText("phones.txt");
                 
                inputFile.ReadLine();
                while (!inputFile.EndOfStream)
                {
                    
                    tempPhone = inputFile.ReadLine().Split(',');
                    
                    cboPhones.Items.Add(tempPhone[0]);
                    
                    phoneDict.Add(tempPhone[0], new Phone(tempPhone));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
        private void btnPhoneDetails_Click(object sender, RoutedEventArgs e)
        {
            PhoneDetailsWindow pdw = new PhoneDetailsWindow();

            string key = cboPhones.SelectedItem.ToString();

            Phone phone;

            if (phoneDict.TryGetValue(key, out phone))
            {
               

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