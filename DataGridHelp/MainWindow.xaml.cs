﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridHelp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = LoadCollectionData();

            var backColorBrush = DataGrid.AlternatingRowBackground;
            var backColorColor = Color.FromArgb(((Color)backColorBrush.GetValue(SolidColorBrush.ColorProperty)).A,
                                                ((Color)backColorBrush.GetValue(SolidColorBrush.ColorProperty)).R,
                                                ((Color)backColorBrush.GetValue(SolidColorBrush.ColorProperty)).B,
                                                ((Color)backColorBrush.GetValue(SolidColorBrush.ColorProperty)).G);

            DataGrid.AlternatingRowBackground = new SolidColorBrush(backColorColor.Blend(Colors.Aqua, 0.7));
        }

        private List<Author> LoadCollectionData()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Mahesh Chand",
                BookTitle = "Graphics Programming with GDI+",
                DOB = new DateTime(1975, 2, 23),
                IsMVP = false
            });
            authors.Add(new Author()
            {
                ID = 201,
                Name = "Mike Gold",
                BookTitle = "Programming C#",
                DOB = new DateTime(1982, 4, 12),
                IsMVP = true
            });
            authors.Add(new Author()
            {
                ID = 244,
                Name = "Mathew Cochran",
                BookTitle = "LINQ in Vista",
                DOB = new DateTime(1985, 9, 11),
                IsMVP = true
            });
            return authors;
        }
    }
}
