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
using System.Text.RegularExpressions;

namespace WCF_WPF_Calculator
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


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalculateService.Service1Client conn = new CalculateService.Service1Client();
            string operText = "";

            switch (oper.Text)
            {
                case "+":
                    operText = "plus";
                    break;
                case "-":
                    operText = "minus";
                    break;
                case "*":
                    operText = "multiply";
                    break;
                case "/":
                    operText = "divide";
                    break;
            }

            try
            {
                Result.Content = conn.Spocti(Convert.ToDecimal(operand1.Text), Convert.ToDecimal(operand2.Text), operText);
            }
            catch(Exception)
            {
                Result.Content = "Cant divide by 0.";
                return;
            }
            
        }
    }
}
