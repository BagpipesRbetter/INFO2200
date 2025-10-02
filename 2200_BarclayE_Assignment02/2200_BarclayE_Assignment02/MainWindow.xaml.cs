/*
Name: Evan Barclay
Class: INFO 2200
Section: See syllabus, schedule, or Canvas course for section
Professor: Sharp
Date: 9/25/2025
Participation or Assignment #: 001
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;

// This project can be found @ "https://github.com/BagpipesRbetter/INFO2200/tree/main/2200_BarclayE_Assignment02"

namespace _2200_BarclayE_Assignment02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FILE = "nutrition.txt";

        private Dictionary<string, food> _food;

        public MainWindow()
        {
            _food = new Dictionary<string, food>(StringComparer.OrdinalIgnoreCase);
            InitializeComponent();
            LoadFoodsFromFile();
        }

        private void LoadFoodsFromFile()
        {
            StreamReader inputFile = null;
            inputFile = File.OpenText(FILE);
            inputFile.ReadLine();

            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('\t');
                if (parts.Length < 28) 
                {
                    continue;
                }

                var f = new food(parts);
                _food[f.FoodName] = f;
                cbFoods.Items.Add(f.FoodName);
            }
        }

        private void cbFoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedName = cbFoods.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selectedName))
            { 
                return; 
            }

            if (_food.TryGetValue(selectedName, out var selectedFood))
            {
                var details = new NutritionDetailsWindow();
                details.SetNutritionalValues(selectedFood);
                details.Owner = this;
                details.ShowDialog();
            }
        }
    }
}
