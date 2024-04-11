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
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void RunNokNod_Click(object sender, RoutedEventArgs e)
        {
            NOK.Text = string.Empty;
            NOD.Text = string.Empty;
            int number;
            try
            {
                if (int.TryParse(FirstNumber.Text, out number) == false || int.TryParse(SecondNumber.Text, out number) == false || int.Parse(FirstNumber.Text) <= 0 || int.Parse(SecondNumber.Text) <= 0)
                {
                    throw new Exception("Введите целое положительное число большее двух. Пример ввода: 3 32 125");
                }
                NOD.Text = NumberLib.NOD(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();
                NOK.Text = NumberLib.NOK(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                FirstNumber.Text = string.Empty;
                SecondNumber.Text = string.Empty;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber.Text = string.Empty;
            SecondNumber.Text = string.Empty;
            NOK.Text = string.Empty;
            NOD.Text = string.Empty;
        }
    }
}
