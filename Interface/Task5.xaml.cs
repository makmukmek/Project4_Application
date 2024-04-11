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
using System.Numerics;
using System.Threading;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Window
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void RunBigIntFactorization_Click(object sender, RoutedEventArgs e)
        {
            ResBigIntFactorization.Document.Blocks.Clear();
            int timeLimitInSeconds = 20; 
            Timer timer = new Timer(TimerCallback, null, timeLimitInSeconds * 1000, Timeout.Infinite);
            BigInteger number;
            try
            {
                if (BigInteger.TryParse(NumberForBigIntFactorization.Text, out number) == false || BigInteger.Parse(NumberForBigIntFactorization.Text) <= 0)
                {
                    throw new Exception("Введите целое положительное число. Пример ввода: 1 23 521");
                }

                ResBigIntFactorization.AppendText(NumberLib.BigIntFactorization(BigInteger.Parse(NumberForBigIntFactorization.Text)));
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Превышено время выполнения программы!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NumberForBigIntFactorization.Text = string.Empty;
                ResBigIntFactorization.Document.Blocks.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                NumberForBigIntFactorization.Text = string.Empty;
            }
            timer.Dispose();
        }
        static void TimerCallback(object state)
        {
            throw new TimeoutException();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            NumberForBigIntFactorization.Text = string.Empty;
            ResBigIntFactorization.Document.Blocks.Clear();
        }
    }
}
