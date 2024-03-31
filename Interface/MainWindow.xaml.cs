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
                        Window Help1 = new Window();
                        Help1.Show();
                        break;
                    case "Факторизация":
                        Window Help2 = new Window();
                        Help2.Show();
                        break;
                    case "Нахождение всех простых чисел в заданном диапазоне":
                        Window Help3 = new Window();
                        Help3.Show();
                        break;
                    case "Найти НОД и НОК":
                        Window Help4 = new Window();
                        Help4.Show();
                        break;
                    case "Факторизация больших чисел":
                        Window Help5 = new Window();
                        Help5.Show();
                        break;
                    case "Задача на тему делителей":
                        Window Help6 = new Window();
                        Help6.Show();
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
