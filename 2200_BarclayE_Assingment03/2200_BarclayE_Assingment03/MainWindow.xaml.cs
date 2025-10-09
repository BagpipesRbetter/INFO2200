using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
Name: Evan Barclay
Class: INFO 2200
Section: See syllabus, schedule, or Canvas course for section
Professor: Sharp
Date: Insert date submitted
Participation or Assignment #: 
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

namespace _2200_BarclayE_Assingment03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Animal animal;
        public MainWindow()
        {
            InitializeComponent();
            radDog.IsChecked = true;
                ImgAnimal.Source = new BitmapImage(new Uri("Images/dog.png", UriKind.Relative));
                
        }

        private void radDog_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("Images/dog.png", UriKind.Relative));
            animal = new Dog("Fur", "Omnivore Prioritizing Meat | Note Wild Type Is Carnivore But Domestic Is Omnivorus");
            lblResults.Content = "";
        }

        private void radStork_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("Images/stork.png", UriKind.Relative));
            animal = new Stork("Feathers", "Obligate Carnivore");
            lblResults.Content = "";
        }

        private void btnSkinType_Click(object sender, RoutedEventArgs e)
        {
            lblResults.Content += animal.SkinType + " | ";
        }

        private void btnFoodType_Click(object sender, RoutedEventArgs e)
        {
            lblResults.Content += animal.FoodType + " | ";
        }

        private void radAxolotl_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("Images/axolotl.png", UriKind.Relative));
            animal = new Axolotl("Permiable Bare Skin", "Insectivore");
            lblResults.Content = "";
        }
    }
}