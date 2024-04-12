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
    /// Логика взаимодействия для Task6.xaml
    /// </summary>
    public partial class Task6 : Window
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void RunPrimeDivisors_Click(object sender, RoutedEventArgs e)
        {
            ResProblem.Document.Blocks.Clear();
            int number;
            try
            {
                if (int.TryParse(StartNumber.Text, out number) == false || int.TryParse(EndNumber.Text, out number) == false || int.TryParse(NumberOfDivisors.Text, out number) == false || int.Parse(StartNumber.Text) <= 0  || int.Parse(EndNumber.Text) <= 0)
                {
                    throw new Exception("Введите целое пложительное число. Пример ввода: 3 32 125");
                }
                if (int.Parse(NumberOfDivisors.Text) <= 1)
                {
                    throw new Exception("Количество делителей долждно быть целым положительным числом большим 1. Пример ввода: 3 32 125");
                }
                ResProblem.AppendText(NumberLib.Problem(int.Parse(StartNumber.Text), int.Parse(EndNumber.Text), int.Parse(NumberOfDivisors.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                StartNumber.Text = string.Empty;
                EndNumber.Text = string.Empty;
                NumberOfDivisors.Text = string.Empty;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            StartNumber.Text = string.Empty;
            EndNumber.Text = string.Empty;
            NumberOfDivisors.Text = string.Empty;
            ResProblem.Document.Blocks.Clear();
        }

        
    }
}
