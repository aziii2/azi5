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

namespace WpfApp7
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
        private void
            PerformOperationButton_Click(object sender, RoutedEventArgs e)
        {
            int.operationNumber = Int32.Parse(operationNumberTextBox.Text);
            double numberA = Double.Parse(numberTextBox.Text);
            double numberB = double.Parse(numberTextBox.Text);
            Double result = PerformOperation(operationNumber, numberA, numberB);
            resultTextBox.Text = result.ToString();
        }
        private double
            PerformOperation(int operationNumber, double numberA, double numberB)
        {
            double result = 0.0;
            switch (operationNumber)
            {
                case 1:
                    result = numberA + numberB;
                    break;
                case 2:
                    result = numberA - numberB;
                    break;
                case 3:
                    result = numberA * numberB;
                    break;
                case 4:
                    result = numberA / numberB;
                    break;
                default:
                    Console.WriteLine("Invalid Operation number");
                    break;
            }
            return result;
        }
    }
}
