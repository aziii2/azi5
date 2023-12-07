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

namespace WpfApp11
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
            CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int N = Int32.Parse(numberTextBox.Text);
            int sum = 0;
            int k = 0;
            int i = 1;
            sum + i <= N;
            i++;
            {
                sum += i;
                k = i;
            }
            resultTextBox.Text = "Наибольшее К:" + к + ", сумма: " + sum;
        }
    }
}
