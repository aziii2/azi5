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

namespace WpfApp12
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
            CheckForOddDigitsButton_Click(object sender, RoutedEventArgs e)
        {
            int N = Int32.Parse(numberTextBox.Text);
            bool hasOddDigits = CheckForOddDigitsButton_Click(N);
            resultTextBox.Text = hasOddDigits.ToString();
        }
        private bool
            CheckForOddDigits(int N)
        {
            while (N > 0)
            {
                int digit = N % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                N = N / 10;
            }
            return false;
        }
    }
}
