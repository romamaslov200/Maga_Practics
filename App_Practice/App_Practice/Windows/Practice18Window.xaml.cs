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

namespace App_Practice.Windows
{
    /// <summary>
    /// Логика взаимодействия для Practice18Window.xaml
    /// </summary>
    public partial class Practice18Window : Window
    {
        public Practice18Window()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskSelector.Items.Add(new { Content = $"Задание {i}" });
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskSelector.SelectedIndex == -1) return;

            int taskNumber = TaskSelector.SelectedIndex + 1;
            ResultBox.Text = SolveTask(taskNumber);
        }

        private string SolveTask(int taskNumber)
        {
            try
            {
                switch (taskNumber)
                {
                    case 1: return SolveTask1();
                    case 2: return SolveTask2();
                    case 3: return SolveTask3();
                    case 4: return SolveTask4();
                    case 5: return SolveTask5();
                    case 6: return SolveTask6();
                    case 7: return SolveTask7();
                    case 8: return SolveTask8();
                    case 9: return SolveTask9();
                    case 10: return SolveTask10();
                    case 11: return SolveTask11();
                    case 12: return SolveTask12();
                    case 13: return SolveTask13();
                    case 14: return SolveTask14();
                    case 15: return SolveTask15();
                    case 16: return SolveTask16();
                    case 17: return SolveTask17();
                    case 18: return SolveTask18();
                    case 19: return SolveTask19();
                    case 20: return SolveTask20();
                    case 21: return SolveTask21();
                    case 22: return SolveTask22();
                    case 23: return SolveTask23();
                    case 24: return SolveTask24();
                    case 25: return SolveTask25();
                    case 26: return SolveTask26();
                    case 27: return SolveTask27();
                    case 28: return SolveTask28();
                    case 29: return SolveTask29();
                    case 30: return SolveTask30();
                    default: return "Задание не реализовано";
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
    }
}
