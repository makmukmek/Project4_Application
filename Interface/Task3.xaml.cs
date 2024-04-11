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
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void RunPrimeDivisors_Click(object sender, RoutedEventArgs e)
        {
            ResPrimeDivisors.Document.Blocks.Clear();
            int number;
            try
            {
                if (int.TryParse(NumberForPrimeDivisors.Text, out number) == false || int.Parse(NumberForPrimeDivisors.Text) <= 2)
                {
                    throw new Exception("Введите целое положительное число большее двух. Пример ввода: 3 32 125");
                }
                ResPrimeDivisors.AppendText(NumberLib.PrimeDivisors(int.Parse(NumberForPrimeDivisors.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NumberForPrimeDivisors.Text = string.Empty;
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberForPrimeDivisors.Text = string.Empty;
            ResPrimeDivisors.Document.Blocks.Clear();
        }

    }
}
