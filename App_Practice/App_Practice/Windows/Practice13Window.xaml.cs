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
    /// Логика взаимодействия для Practice13Window.xaml
    /// </summary>
    public partial class Practice13Window : Window
    {
        public Practice13Window()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskSelector.Items.Add(new { Content = $"Задание {i}" });
            }
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

        private string SolveTask1()
        {
            string binary = "1101";
            int decimalNum = Convert.ToInt32(binary, 2);
            return $"Двоичное: {binary}\nДесятичное: {decimalNum}";
        }

        private string SolveTask2()
        {
            string binary = "1101";
            int decimalNum = Convert.ToInt32(binary, 2);
            string octal = Convert.ToString(decimalNum, 8);
            return $"Двоичное: {binary}\nВосьмеричное: {octal}";
        }

        private string SolveTask3()
        {
            string binary = "1101";
            int decimalNum = Convert.ToInt32(binary, 2);
            string hex = decimalNum.ToString("X");
            return $"Двоичное: {binary}\nШестнадцатеричное: {hex}";
        }

        private string SolveTask4()
        {
            string binary = "1101.101";
            string[] parts = binary.Split('.');
            int intPart = Convert.ToInt32(parts[0], 2);

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                    fracPart += Math.Pow(2, -(i + 1));
            }

            return $"Двоичное: {binary}\nДесятичное: {intPart + fracPart}";
        }

        private string SolveTask5()
        {
            string binary = "1101.101";
            string[] parts = binary.Split('.');
            int intPart = Convert.ToInt32(parts[0], 2);
            string octalInt = Convert.ToString(intPart, 8);

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                    fracPart += Math.Pow(2, -(i + 1));
            }

            string octalFrac = "";
            double temp = fracPart;
            for (int i = 0; i < 4; i++)
            {
                temp *= 8;
                int digit = (int)temp;
                octalFrac += digit;
                temp -= digit;
            }

            return $"Двоичное: {binary}\nВосьмеричное: {octalInt}.{octalFrac}";
        }

        private string SolveTask6()
        {
            string binary = "1101.101";
            string[] parts = binary.Split('.');
            int intPart = Convert.ToInt32(parts[0], 2);
            string hexInt = intPart.ToString("X");

            double fracPart = 0;
            for (int i = 0; i < parts[1].Length; i++)
            {
                if (parts[1][i] == '1')
                    fracPart += Math.Pow(2, -(i + 1));
            }

            string hexFrac = "";
            double temp = fracPart;
            for (int i = 0; i < 4; i++)
            {
                temp *= 16;
                int digit = (int)temp;
                hexFrac += digit.ToString("X");
                temp -= digit;
            }

            return $"Двоичное: {binary}\nШестнадцатеричное: {hexInt}.{hexFrac}";
        }

        private string SolveTask7()
        {
            int[] numbers = { 12, 34, 56, 78, 90, 23, 45, 67, 89, 10, 32, 54, 76, 98, 21 };
            int[] swapped = numbers.Select(n => (n % 10) * 10 + (n / 10)).ToArray();
            return $"Исходные: {string.Join(" ", numbers)}\nПосле замены: {string.Join(" ", swapped)}";
        }

        private string SolveTask8()
        {
            string[] octals = { "12", "34", "56", "70", "25", "43", "61", "17", "35" };
            int[] decimals = octals.Select(o => Convert.ToInt32(o, 8)).ToArray();
            return $"Восьмеричные: {string.Join(" ", octals)}\nДесятичные: {string.Join(" ", decimals)}";
        }

        private string SolveTask9()
        {
            int[] numbers = { 12, 34, 56, 78, 90, 23, 45 };
            int[] tens = numbers.Select(n => n / 10).ToArray();
            return $"Исходные: {string.Join(" ", numbers)}\nСтаршие разряды: {string.Join(" ", tens)}";
        }

        private string SolveTask10()
        {
            double[] array1 = { 1.5, 2.3, 3.7, 4.1, 5.9, 6.2, 7.4 };
            double[] array2 = { 8.1, 9.5, 10.2, 11.8, 12.4, 13.9, 14.3, 15.7, 16.2 };
            double[] merged = array1.Concat(array2).OrderByDescending(x => x).ToArray();
            return $"Объединенный массив:\n{string.Join(" ", merged)}";
        }

        private string SolveTask11()
        {
            string[] binaries = { "101", "110", "010", "101", "111", "000", "110", "001", "101", "010", "111", "100" };
            var filtered = binaries.Where(b => binaries.Count(x => x == b) <= 2).ToArray();
            return $"Исходные: {string.Join(" ", binaries)}\nПосле фильтрации: {string.Join(" ", filtered)}";
        }

        private string SolveTask12()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 3, 9, 10 };
            var duplicates = numbers.Select((n, i) => new { Value = n, Index = i })
                                 .GroupBy(x => x.Value)
                                 .FirstOrDefault(g => g.Count() > 1);

            if (duplicates != null)
                return $"Дубликат: {duplicates.Key} на позициях: {string.Join(", ", duplicates.Select(x => x.Index))}";
            else
                return "Дубликаты не найдены";
        }

        private string SolveTask13()
        {
            string binary = "1101101";
            string shifted = binary.Substring(2) + binary.Substring(0, 2);
            int original = Convert.ToInt32(binary, 2);
            int shiftedValue = Convert.ToInt32(shifted, 2);
            return $"Исходное: {binary}\nПосле сдвига: {shifted}\nРазность: {original - shiftedValue}";
        }

        private string SolveTask14()
        {
            string[] binaries = { "1101", "1010", "1111", "1001", "1011" };
            var sorted = binaries.OrderByDescending(b => Convert.ToInt32(b, 2)).ToArray();
            int sum = sorted.Sum(b => Convert.ToInt32(b, 2));
            return $"Отсортированные: {string.Join(" ", sorted)}\nСумма: {sum}";
        }

        private string SolveTask15()
        {
            string[] binaries = { "1101", "1010", "1111", "1001", "1011" };
            var sorted = binaries.OrderBy(b => Convert.ToInt32(b, 2)).ToArray();
            double avg = sorted.Average(b => Convert.ToInt32(b, 2));
            return $"Отсортированные: {string.Join(" ", sorted)}\nСреднее: {avg:F2}";
        }

        private string SolveTask16()
        {
            string[] binaries = { "1101", "1010", "1111", "1001", "1011" };
            var values = binaries.Select(b => Convert.ToInt32(b, 2)).ToArray();
            int minIndex = Array.IndexOf(values, values.Min());
            int maxIndex = Array.IndexOf(values, values.Max());

            string temp = binaries[minIndex];
            binaries[minIndex] = binaries[maxIndex];
            binaries[maxIndex] = temp;

            return $"После замены: {string.Join(" ", binaries)}";
        }

        private string SolveTask30()
        {
            int[] numbers = { 5, 10, 15 };
            string[] binaries = numbers.Select(n => Convert.ToString(n, 2)).ToArray();
            return $"Десятичные: {string.Join(" ", numbers)}\nДвоичные: {string.Join(" ", binaries)}";
        }

        private string SolveTask17()
        {
            string[] binaries = { "1010", "1101", "1001", "1111", "1011" };
            int[] decimals = binaries.Select(b => Convert.ToInt32(b, 2)).ToArray();
            int max = decimals.Max();
            return $"Двоичные: {string.Join(" ", binaries)}\n" +
                   $"Десятичные: {string.Join(" ", decimals)}\n" +
                   $"Максимальное: {max} ({Convert.ToString(max, 2)})";
        }

        private string SolveTask18()
        {
            string[] binaries = { "1010", "1101", "1001", "1111", "1011" };
            int[] decimals = binaries.Select(b => Convert.ToInt32(b, 2)).ToArray();
            int min = decimals.Min();
            return $"Двоичные: {string.Join(" ", binaries)}\n" +
                   $"Десятичные: {string.Join(" ", decimals)}\n" +
                   $"Минимальное: {min} ({Convert.ToString(min, 2)})";
        }

        private string SolveTask19()
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int sum = numbers.Sum();
            return $"Числа: {string.Join(" ", numbers)}\n" +
                   $"Сумма: {sum}\n" +
                   $"Двоичное представление суммы: {Convert.ToString(sum, 2)}";
        }

        private string SolveTask20()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = numbers.Average();
            return $"Числа: {string.Join(" ", numbers)}\n" +
                   $"Среднее: {average:F2}\n" +
                   $"Двоичное целой части: {Convert.ToString((int)average, 2)}";
        }

        private string SolveTask21()
        {
            int[] numbers = { 12, 17, 21, 25, 30 };
            var multiples = numbers.Where(n => n % 3 == 0).ToArray();
            return $"Исходный массив: {string.Join(" ", numbers)}\n" +
                   $"Числа, кратные 3: {(multiples.Any() ? string.Join(" ", multiples) : "отсутствуют")}";
        }

        private string SolveTask22()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = numbers.Count(n => n % 2 == 0);
            return $"Массив: {string.Join(" ", numbers)}\n" +
                   $"Количество четных чисел: {count}\n" +
                   $"Двоичное представление количества: {Convert.ToString(count, 2)}";
        }

        private string SolveTask23()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(numbers);
            return $"Исходный массив: 1 2 3 4 5 6 7 8 9 10\n" +
                   $"Перевернутый массив: {string.Join(" ", numbers)}";
        }

        private string SolveTask24()
        {
            string[] binaries = { "1010", "1101", "1001", "1111", "1011" };
            var sorted = binaries.OrderBy(b => Convert.ToInt32(b, 2)).ToArray();
            return $"Исходные: {string.Join(" ", binaries)}\n" +
                   $"Отсортированные: {string.Join(" ", sorted)}";
        }

        private string SolveTask25()
        {
            string[] binaries = { "1010", "1101", "1001", "1111", "1011" };
            var sorted = binaries.OrderByDescending(b => Convert.ToInt32(b, 2)).ToArray();
            return $"Исходные: {string.Join(" ", binaries)}\n" +
                   $"Отсортированные: {string.Join(" ", sorted)}";
        }

        private string SolveTask26()
        {
            int[] numbers = { 45, 60, 32, 75, 50, 85, 28, 90, 65, 40 };
            var filtered = numbers.Where(n => n > 50).ToArray();
            return $"Исходный массив: {string.Join(" ", numbers)}\n" +
                   $"Числа > 50: {(filtered.Any() ? string.Join(" ", filtered) : "отсутствуют")}";
        }

        private string SolveTask27()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 3, 5, 8, 10 };
            var common = array1.Intersect(array2).ToArray();
            return $"Массив 1: {string.Join(" ", array1)}\n" +
                   $"Массив 2: {string.Join(" ", array2)}\n" +
                   $"Общие элементы: {(common.Any() ? string.Join(" ", common) : "отсутствуют")}";
        }

        private string SolveTask28()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 3, 5, 8, 10 };
            var unique = array1.Union(array2).Except(array1.Intersect(array2)).ToArray();
            return $"Массив 1: {string.Join(" ", array1)}\n" +
                   $"Массив 2: {string.Join(" ", array2)}\n" +
                   $"Уникальные элементы: {(unique.Any() ? string.Join(" ", unique) : "отсутствуют")}";
        }

        private string SolveTask29()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 3, 5, 8, 10 };
            var difference = array1.Except(array2).ToArray();
            return $"Массив 1: {string.Join(" ", array1)}\n" +
                   $"Массив 2: {string.Join(" ", array2)}\n" +
                   $"Элементы 1-го массива, отсутствующие во 2-м: " +
                   $"{(difference.Any() ? string.Join(" ", difference) : "отсутствуют")}";
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
    }
}
