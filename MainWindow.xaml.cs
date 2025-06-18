﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hello_World
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

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (HelloRadio.IsChecked == true)
            {
                MessageTextBlock.Text = "Hello World";
                
            }
            if (GoodByRadio.IsChecked == true)
            {
                MessageTextBlock.Text = "GoodBye World";
                
            }
        }
    }
}