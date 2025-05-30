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

namespace _05.WpfRoutedEvent_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click_1 (object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            double a = Double.Parse(txtBox.Text);
            switch (feSource.Name)
            {
                case "butAdd":
                    a += a;
                    break;
                case "butMult":
                    a *= a;
                    break;
                case "butSquareRoot":
                    a = Math.Sqrt(a);
                    break;
            }
            e.Handled = true;
            txtBox.Text = String.Format("{0:#.##}", a);
        }
    }

   
}
