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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarDealership
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

        private void Button_Buyers(object sender, RoutedEventArgs e)
        {
            frame.Content = new Buyer();
        }

        private void Button_Stamps(object sender, RoutedEventArgs e)
        {
            frame.Content = new Stamp();
        }

        private void Button_Staff(object sender, RoutedEventArgs e)
        {
            frame.Content = new Employee();
        }

        private void Button_Auto(object sender, RoutedEventArgs e)
        {
            frame.Content = new Auto();
        }

        private void Button_Sales(object sender, RoutedEventArgs e)
        {
            frame.Content = new Sale();
        }
    }
}
