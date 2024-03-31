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

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Description_Click(object sender, RoutedEventArgs e)
        {
            string selectedTask = (SelectTask.SelectedItem as ComboBoxItem).Content.ToString();

            if (selectedTask != null)
            {
                switch (selectedTask)
                {
                    case "Нахождение всех делителей заданного числа":
                        Help1 help1 = new Help1
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help1.Show();
                        break;
                    case "Факторизация":
                        Help2 help2 = new Help2
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help2.Show();
                        break;
                    case "Нахождение всех простых чисел в заданном диапазоне":
                        Help3 help3 = new Help3
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help3.Show();
                        break;
                    case "Найти НОД и НОК":
                        Help4 help4 = new Help4
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help4.Show();
                        break;
                    case "Факторизация больших чисел":
                        Help5 help5 = new Help5
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help5.Show();
                        break;
                    case "Задача на тему делителей":
                        Help6 help6 = new Help6
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        help6.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ActivateTask_Click(object sender, RoutedEventArgs e)
        {
            string selectedTask = (SelectTask.SelectedItem as ComboBoxItem).Content.ToString();

            if (selectedTask != null)
            {
                switch (selectedTask)
                {
                    case "Нахождение всех делителей заданного числа":
                        Task1 task1 = new Task1
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task1.Show();
                        break;
                    case "Факторизация":
                        Task2 task2 = new Task2
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task2.Show();
                        break;
                    case "Нахождение всех простых чисел в заданном диапазоне":
                        Task3 task3 = new Task3
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task3.Show();
                        break;
                    case "Найти НОД и НОК":
                        Task4 task4 = new Task4
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task4.Show();
                        break;
                    case "Факторизация больших чисел":
                        Task5 task5 = new Task5
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task5.Show();
                        break;
                    case "Задача на тему делителей":
                        Task6 task6 = new Task6
                        {
                            WindowStartupLocation = WindowStartupLocation.CenterScreen
                        };
                        task6.Show();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
