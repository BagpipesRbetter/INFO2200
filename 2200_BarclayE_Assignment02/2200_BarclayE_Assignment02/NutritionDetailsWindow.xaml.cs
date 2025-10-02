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

namespace _2200_BarclayE_Assignment02
{
    /// <summary>
    /// Interaction logic for NutritionDetailsWindow.xaml
    /// </summary>
    public partial class NutritionDetailsWindow : Window
    {
        public NutritionDetailsWindow()
        {
            InitializeComponent();
        }
        public void SetNutritionalValues(food f)
        {
            lblFood.Content = f.FoodName;
            lblFoodType.Content = f.FoodType;
            lblServingSize.Content = f.ServingSize;
            lblWeight.Content = f.Weight.ToString();
            lblPercentWater.Content = f.PercentWater.ToString();
            lblCalories.Content = f.Energy.ToString();
            lblProtein.Content = f.Protien.ToString();
            lblCarbohydrates.Content = f.Carbohydrate.ToString();
            lblFiber.Content = f.Fiber.ToString();
            lblCholesterol.Content = f.Cholesterol.ToString();
            lblTotalFat.Content = f.TotalFat.ToString();
            lblSaturatedFat.Content = f.SaturatedFat.ToString();
            lblMonosaturatedFat.Content = f.MonounsaturatedFat.ToString();
            lblPolyunsaturatedFat.Content = f.PolyunsaturatedFat.ToString();
            lblCalcium.Content = f.Calcium.ToString();
            lblIron.Content = f.Iron.ToString();
            lblMagnesium.Content = f.Magnesium.ToString();
            lblSodium.Content = f.Sodium.ToString();
            lblPhosporous.Content = f.Phosphorus.ToString();
            lblCaPRatio.Content = f.CaPRation.ToString();
            lblPotassium.Content = f.Potassium.ToString();
            lblZinc.Content = f.Zinc.ToString();
            lblNiacin.Content = f.Niacin.ToString();
            lblThiamin.Content = f.Thiamin.ToString();
            lblRiboflavin.Content = f.Riboflavin.ToString();
            lblVitA.Content = f.VitaminA.ToString();
            lblVitB6.Content = f.VitaminB6.ToString();
            lblVitC.Content = f.VitaminC.ToString();
        }
    }
}
