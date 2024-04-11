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
using System.Windows.Shapes;
using Library;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void RunDivisors_Click(object sender, RoutedEventArgs e)
        {
            ResDivisors.Document.Blocks.Clear();
            int number;
            try
            {
                if (int.TryParse(NumberForDivisors.Text, out number) == false || int.Parse(NumberForDivisors.Text) <= 0)
                {
                    throw new Exception("Введите целое положительное число. Пример ввода: 1 23 521");
                }
                ResDivisors.AppendText(NumberLib.Divisors(int.Parse(NumberForDivisors.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NumberForDivisors.Text = string.Empty;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberForDivisors.Text = string.Empty;
            ResDivisors.Document.Blocks.Clear();
        }
    }
}