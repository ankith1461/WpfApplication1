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

namespace WpfApplication1
{
    class Person
    {
        string name = "Nirusha";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            Person p = new Person();
            this.DataContext=p;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("My First WPF");
        }
    }

}
