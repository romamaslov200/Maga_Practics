using System;
using App_Practice;
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
using App_Practice.Windows;

namespace App_Practice
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
        private void Practice12_Click(object sender, RoutedEventArgs e)
        {
            var work12 = new Practice12Window();
            work12.Show();
            this.Hide();
        }

        private void Practice13_Click(object sender, RoutedEventArgs e)
        {
            var work13 = new Practice13Window();
            work13.Show();
            this.Hide();
        }

        private void Practice14_Click(object sender, RoutedEventArgs e)
        {
            var work14 = new Practice14Window();
            work14.Show();
            this.Hide();
        }
        private void Practice15_Click(object sender, RoutedEventArgs e)
        {
            var work15 = new Practice15Window();
            work15.Show();
            this.Hide();
        }
        private void Practice16_Click(object sender, RoutedEventArgs e)
        {
            var work16 = new Practice16Window();
            work16.Show();
            this.Hide();
        }
        private void Practice17_Click(object sender, RoutedEventArgs e)
        {
            var work17 = new Practice17Window();
            work17.Show();
            this.Hide();
        }
        private void Practice18_Click(object sender, RoutedEventArgs e)
        {
            var work18 = new Practice18Window();
            work18.Show();
            this.Hide();
        }

    }
}
