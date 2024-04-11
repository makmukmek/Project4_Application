using Library;
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

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void RunFactorization_Click(object sender, RoutedEventArgs e)
        {
            ResFactorization.Document.Blocks.Clear();
            int number;
            try
            {
                if (int.TryParse(NumberForFactorization.Text, out number) == false || int.Parse(NumberForFactorization.Text) <= 0)
                {
                    throw new Exception("Введите целое положительное число. Пример ввода: 1 23 521");
                }
                ResFactorization.AppendText(NumberLib.Factorization(int.Parse(NumberForFactorization.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NumberForFactorization.Text = string.Empty;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberForFactorization.Text = string.Empty;
            ResFactorization.Document.Blocks.Clear();
        }
    }
}
