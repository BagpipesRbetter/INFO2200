using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace _2200_BarclayE_Participation03
{
    public partial class MainWindow : Window
    {
        Dictionary<string, Plant> plantDictionary = new Dictionary<string, Plant>();
        public MainWindow()
        {
            InitializeComponent();
            LoadValues();
        }

        public void LoadValues()
        {
            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Tropical");

            CbType.Items.Add("Tree");
            CbType.Items.Add("Shrub");
            CbType.Items.Add("Flower");
        }

        public bool ValidInput()
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(TxtBoxName.Text)) errorMessage += "Please enter a name for the plant.\n\n";
            if (CbEnvironment.SelectedIndex == -1) errorMessage += "Please select an environment.\n\n";
            if (CbType.SelectedIndex == -1) errorMessage += "Please select a plant type.\n\n";

            if (errorMessage == "")
                return true;

            MessageBox.Show(errorMessage);
            return false;
        }

        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidInput()) return;

            string env = CbEnvironment.SelectedItem!.ToString()!;
            string type = CbType.SelectedItem!.ToString()!;
            string name = TxtBoxName.Text.Trim();

            Plant? plant = null;

            switch (type)
            {
                case "Tree":
                    plant = new Tree(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                    break;
                case "Shrub":
                    plant = new Shrub(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);

                    break;
                case "Flower":
                    plant = new Flower(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                    break;
                default:
                    MessageBox.Show("Unknown plant type.");
                    break;
            }

            if (plant != null)
            {
                plantDictionary.Add(plant.Name, plant);
                LstBoxPlants.Items.Add(plant.Name);
            }
        }

        public void BtnShowDetails_Click(object sender, RoutedEventArgs e) 
        {
            if (LstBoxPlants.SelectedIndex > -1)
            {
                if (plantDictionary.TryGetValue(LstBoxPlants.SelectedItem.ToString(), out Plant slPlant))
                {
                    Detailswindow detailsWindow = new Detailswindow();
                    detailsWindow.LblEnvironmentResults.Content = slPlant.Environment;
                    detailsWindow.LblTypeResults.Content = slPlant.Type;
                    detailsWindow.LblNameResults.Content = slPlant.Name;
                    detailsWindow.Show();
                }
                else
                {
                    MessageBox.Show("Plant not found in dictionary.");
                }
            }
        }

        private void CbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CbType.SelectedItem)
            {
                case "Flower":
                    ImgPlant.Source = new BitmapImage(new Uri("/rose.png", UriKind.Relative));
                        break;
                case "Tree":
                    ImgPlant.Source = new BitmapImage(new Uri("/tree.jpg", UriKind.Relative));
                        break;
                case "Shrub":
                    ImgPlant.Source = new BitmapImage(new Uri("/shrub.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        private void CbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CbEnvironment.SelectedItem)
            {
                case "Forest":
                    ImgEnvironment.Source = new BitmapImage(new
                    Uri("/forest.png", UriKind.Relative));
                    break;
                case "Desert":
                    ImgEnvironment.Source = new BitmapImage(new
                    Uri("/desert.png", UriKind.Relative));
                    break;
                case "Tropical":
                    ImgEnvironment.Source = new BitmapImage(new
                    Uri("/tropical.jpg", UriKind.Relative));
                    break;
                default:
                    break;

            }
            }
        }
}