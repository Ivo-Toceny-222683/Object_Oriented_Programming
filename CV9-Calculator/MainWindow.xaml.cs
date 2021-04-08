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

namespace CV9_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            display.Content = calculator.Display;
            memory.Content = calculator.Memory;
        }
        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.NumButton((sender as Button).Content.ToString());
            display.Content = calculator.Display;
            memory.Content = calculator.Memory;
        }

        private void OperButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.OperButton((sender as Button).Content.ToString());
            display.Content = calculator.Display;
            memory.Content = calculator.Memory;
        }

        private void SystemButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.SystemButton((sender as Button).Content.ToString());
            display.Content = calculator.Display;
            memory.Content = calculator.Memory;
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ResultButton();
            display.Content = calculator.Display;
            memory.Content = calculator.Memory;
        }
    }

}
