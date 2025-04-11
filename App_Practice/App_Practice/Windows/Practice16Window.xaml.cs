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
    /// Логика взаимодействия для Practice16Window.xaml
    /// </summary>
    public partial class Practice16Window : Window
    {
        public Practice16Window()
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

        private string SolveTask1()
        {
            double[] numbers = GenerateRandomNumbers(10);
            double product = 1;
            foreach (double num in numbers)
            {
                product *= num;
            }
            return $"Сгенерированные числа:\n{string.Join(", ", numbers)}\n\nПроизведение элементов: {product}";
        }

        private string SolveTask2()
        {
            int[] numbers = GenerateRandomIntNumbers(20, -50, 50);

            if (numbers.Any(n => n == 0)) return "Ошибка: Массив содержит нули";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Ошибка: Количество положительных и отрицательных чисел не совпадает";

            var sorted = numbers.Where(n => n > 0).Concat(numbers.Where(n => n < 0));

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Отсортированные числа (сначала положительные, потом отрицательные):\n" +
                   $"{string.Join(", ", sorted)}";
        }

        private string SolveTask3()
        {
            int[] numbers = GenerateRandomIntNumbers(15, 1, 100);
            var squares = numbers.Where(n =>
            {
                int root = (int)Math.Sqrt(n);
                return root * root == n;
            });

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Точные квадраты:\n{string.Join(", ", squares)}";
        }

        private string SolveTask4()
        {
            double[] numbers = GenerateRandomNumbers(15);
            double min = numbers.Min();
            double max = numbers.Max();

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Минимум: {min}, Максимум: {max}, Сумма минимума и максимума: {min + max}";
        }

        private string SolveTask5()
        {
            var dates = GenerateRandomDates(30);
            var yearGroups = dates.GroupBy(d => d.Year)
                                .OrderByDescending(g => g.Count())
                                .First();

            return $"Сгенерированные даты:\n{string.Join("\n", dates)}\n\n" +
                   $"Год с наибольшим количеством дат: {yearGroups.Key}\n" +
                   $"Номера месяцев: {string.Join(", ", yearGroups.Select(d => d.Month))}";
        }

        private string SolveTask6()
        {
            double[] numbers = GenerateRandomNumbers(10);
            double sum = numbers.Sum();
            double product = numbers.Aggregate(1.0, (acc, num) => acc * num);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Абсолютная сумма: {Math.Abs(sum)}\n" +
                   $"Квадрат произведения: {product * product}";
        }

        private string SolveTask7()
        {
            double[] numbers = GenerateRandomNumbers(10);
            if (numbers.Length < 1) return "Ошибка: Массив пуст";

            double diff = numbers[0] - numbers[numbers.Length - 1];

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Разница между первым и последним элементом: {diff}";
        }

        private string SolveTask8()
        {
            int[] numbers = GenerateRandomIntNumbers(20, 1, 100);
            int evenCount = numbers.Count(n => n % 2 == 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Количество четных чисел: {evenCount}";
        }

        private string SolveTask9()
        {
            string randomText = GenerateRandomText();
            return $"Сгенерированный текст:\n{randomText}";
        }

        private string SolveTask10()
        {
            string text1 = GenerateRandomText(10);
            string text2 = GenerateRandomText(15);

            var chars1 = text1.ToCharArray();
            var chars2 = text2.ToCharArray();

            var interleaved = new List<char>();
            int maxLength = Math.Max(chars1.Length, chars2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < chars1.Length) interleaved.Add(chars1[i]);
                if (i < chars2.Length) interleaved.Add(chars2[i]);
            }

            return $"Текст 1:\n{text1}\n\nТекст 2:\n{text2}\n\n" +
                   $"Чередованное содержимое:\n{new string(interleaved.ToArray())}";
        }

        private string SolveTask11()
        {
            double[] numbers = GenerateRandomNumbers(10);
            return $"Сгенерированные числа:\n{string.Join(", ", numbers)}\n\nСумма элементов: {numbers.Sum()}";
        }

        private string SolveTask12()
        {
            string text = GenerateRandomText(10);

            if (text.Length < 2) return "Ошибка: Текст содержит менее 2 символов";

            char first = text[0];
            char second = text[1];

            if (char.IsDigit(first) && char.IsDigit(second))
            {
                int number = int.Parse(first.ToString()) * 10 + int.Parse(second.ToString());
                return $"Текст:\n{text}\n\n" +
                       $"Первые два символа образуют число: {number}\n" +
                       $"Четное: {number % 2 == 0}";
            }

            return $"Текст:\n{text}\n\nПервые два символа не являются цифрами";
        }

        private string SolveTask13()
        {
            int[] numbers = GenerateRandomIntNumbers(15, 1, 100);
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Четные числа:\n{string.Join(", ", evenNumbers)}";
        }

        private string SolveTask14()
        {
            double[] numbers = GenerateRandomNumbers(10, -50, 50);
            double maxAbsEvenIndex = 0;

            for (int i = 1; i < numbers.Length; i += 2)
            {
                double abs = Math.Abs(numbers[i]);
                if (abs > maxAbsEvenIndex) maxAbsEvenIndex = abs;
            }

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Максимальное по модулю значение на четных позициях: {maxAbsEvenIndex}";
        }

        private string SolveTask15()
        {
            double[] numbers = GenerateRandomNumbers(5);
            if (numbers.Length == 0) return "Ошибка: Массив пуст";

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Последний элемент: {numbers[numbers.Length - 1]}";
        }

        private string SolveTask16()
        {
            var dates = GenerateRandomDates(10);
            var springDates = dates.Where(d => d.Month >= 3 && d.Month <= 5);

            return $"Сгенерированные даты:\n{string.Join("\n", dates.Select(d => d.ToString("dd.MM.yyyy")))}\n\n" +
                   $"Весенние даты:\n{string.Join("\n", springDates.Select(d => d.ToString("dd.MM.yyyy")))}";
        }

        private string SolveTask17()
        {
            int[] numbers = GenerateRandomIntNumbers(20, 1, 100);
            var result = numbers.Where(n => n % 3 == 0 && n % 7 != 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Числа, делящиеся на 3, но не на 7:\n{string.Join(", ", result)}";
        }

        private string SolveTask18()
        {
            double[] numbers = GenerateRandomNumbers(10);
            double minEvenIndex = double.MaxValue;

            for (int i = 1; i < numbers.Length; i += 2)
            {
                if (numbers[i] < minEvenIndex) minEvenIndex = numbers[i];
            }

            if (minEvenIndex == double.MaxValue) return "Нет элементов с четными индексами";

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Минимальное значение на четных позициях: {minEvenIndex}";
        }

        private string SolveTask19()
        {
            int[] numbers = GenerateRandomIntNumbers(15, 1, 50);
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var oddNumbers = numbers.Where(n => n % 2 != 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Четные числа:\n{string.Join(", ", evenNumbers)}\n\n" +
                   $"Нечетные числа:\n{string.Join(", ", oddNumbers)}";
        }

        private string SolveTask20()
        {
            string text = GenerateRandomText(15);
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);

            return $"Исходный текст:\n{text}\n\n" +
                   $"Текст в обратном порядке:\n{new string(chars)}";
        }

        private string SolveTask21()
        {
            var dates = GenerateRandomDates(5);
            var latestDate = dates.Max();

            return $"Сгенерированные даты:\n{string.Join("\n", dates.Select(d => d.ToString("dd.MM.yyyy")))}\n\n" +
                   $"Самая поздняя дата: {latestDate.ToString("dd.MM.yyyy")}";
        }

        private string SolveTask22()
        {
            string text1 = GenerateRandomText(10);
            string text2 = GenerateRandomText(10);

            return $"Текст 1:\n{text1}\n\nТекст 2:\n{text2}\n\n" +
                   $"Объединенное содержимое:\n{text1 + text2}";
        }

        private string SolveTask23()
        {
            int[] numbers = GenerateRandomIntNumbers(10, -50, 50);

            if (numbers.Any(n => n == 0)) return "Ошибка: Массив содержит нули";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Ошибка: Количество положительных и отрицательных чисел не совпадает";

            var positives = numbers.Where(n => n > 0).ToList();
            var negatives = numbers.Where(n => n < 0).ToList();

            var result = new List<int>();
            for (int i = 0; i < positives.Count; i++)
            {
                result.Add(positives[i]);
                result.Add(negatives[i]);
            }

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Чередование положительных и отрицательных:\n{string.Join(", ", result)}";
        }

        private string SolveTask24()
        {
            int[] numbers = GenerateRandomIntNumbers(20, 1, 100);
            int count = numbers.Count(n =>
            {
                if (n % 2 != 0) return false;
                int root = (int)Math.Sqrt(n);
                return root * root == n && root % 2 != 0;
            });

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Количество квадратов нечетных чисел: {count}";
        }

        private string SolveTask25()
        {
            double[] numbers = GenerateRandomNumbers(8);
            double sumOfSquares = numbers.Sum(n => n * n);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Сумма квадратов: {sumOfSquares}";
        }

        private string SolveTask26()
        {
            double[] numbers = GenerateRandomNumbers(2);
            if (numbers.Length < 2) return "Ошибка: Нужно как минимум 2 числа";

            double diffOfCubes = Math.Pow(numbers[0], 3) - Math.Pow(numbers[1], 3);

            return $"Исходные числа:\n{string.Join(", ", numbers)}\n\n" +
                   $"Разность кубов (первое - второе): {diffOfCubes}";
        }

        private string SolveTask27()
        {
            int[] numbers = GenerateRandomIntNumbers(15, 1, 50);
            int count = numbers.Count(n => n % 2 == 0 && (n / 2) % 2 != 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Количество удвоенных нечетных чисел: {count}";
        }

        private string SolveTask28()
        {
            int[] numbers = GenerateRandomIntNumbers(8, -50, 50);

            if (numbers.Any(n => n == 0)) return "Ошибка: Массив содержит нули";
            if (numbers.Length % 4 != 0) return "Ошибка: Количество элементов должно делиться на 4";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Ошибка: Количество положительных и отрицательных чисел не совпадает";

            var positives = numbers.Where(n => n > 0).ToList();
            var negatives = numbers.Where(n => n < 0).ToList();

            var result = new List<int>();
            for (int i = 0; i < positives.Count; i += 2)
            {
                if (i + 1 < positives.Count)
                {
                    result.Add(positives[i]);
                    result.Add(positives[i + 1]);
                }

                if (i + 1 < negatives.Count)
                {
                    result.Add(negatives[i]);
                    result.Add(negatives[i + 1]);
                }
            }

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Два положительных, два отрицательных:\n{string.Join(", ", result)}";
        }

        private string SolveTask29()
        {
            var dates = GenerateRandomDates(5);
            var earliestDate = dates.Min();

            return $"Сгенерированные даты:\n{string.Join("\n", dates.Select(d => d.ToString("dd.MM.yyyy")))}\n\n" +
                   $"Самая ранняя дата: {earliestDate.ToString("dd.MM.yyyy")}";
        }

        private string SolveTask30()
        {
            int[] numbers = GenerateRandomIntNumbers(10, -50, 50);

            if (numbers.Any(n => n == 0)) return "Ошибка: Массив содержит нули";

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            if (positiveCount != negativeCount)
                return "Ошибка: Количество положительных и отрицательных чисел не совпадает";

            var oddNumbers = numbers.Where(n => n % 2 != 0);
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            return $"Исходный массив:\n{string.Join(", ", numbers)}\n\n" +
                   $"Сначала нечетные, затем четные:\n{string.Join(", ", oddNumbers.Concat(evenNumbers))}";
        }

        private double[] GenerateRandomNumbers(int count, double min = 0, double max = 100)
        {
            Random rand = new Random();
            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Math.Round(min + (rand.NextDouble() * (max - min)), 2);
            }
            return numbers;
        }

        private double[] GenerateRandomNumbers(int count)
        {
            Random rand = new Random();
            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Math.Round(rand.NextDouble() * 100, 2);
            }
            return numbers;
        }

        private int[] GenerateRandomIntNumbers(int count, int min, int max)
        {
            Random rand = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(min, max);
            }
            return numbers;
        }

        private DateTime[] GenerateRandomDates(int count)
        {
            Random rand = new Random();
            DateTime[] dates = new DateTime[count];
            DateTime start = new DateTime(2010, 1, 1);
            int range = (DateTime.Today - start).Days;

            for (int i = 0; i < count; i++)
            {
                dates[i] = start.AddDays(rand.Next(range));
            }
            return dates;
        }

        private string GenerateRandomText(int length = 20)
        {
            Random rand = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}

