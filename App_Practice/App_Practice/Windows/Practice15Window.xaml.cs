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
    /// Логика взаимодействия для Practice15Window.xaml
    /// </summary>
    public partial class Practice15Window : Window
    {
        public Practice15Window()
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

        private Random rnd = new Random();

        private char[] GenerateCharArray(int size)
        {
            char[] array = new char[size];
            for (int i = 0; i < size; i++)
            {
                int type = rnd.Next(3);
                if (type == 0)
                    array[i] = (char)rnd.Next('a', 'z' + 1);
                else if (type == 1)
                    array[i] = (char)rnd.Next('A', 'Z' + 1);
                else if (type == 2)
                    array[i] = (char)rnd.Next('0', '9' + 1);
                else
                    array[i] = (char)rnd.Next(32, 127);
            }
            return array;
        }

        private char[,] GenerateCharMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = GenerateCharArray(1)[0];
            return matrix;
        }

        private string ArrayToString(char[] array)
        {
            return new string(array);
        }

        private string MatrixToString(char[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result += matrix[i, j] + " ";
                result += "\n";
            }
            return result;
        }

        private string SolveTask1()
        {
            char[] array = GenerateCharArray(10);
            char[] result = (char[])array.Clone();

            for (int i = 0; i < 10; i++)
                if (char.IsDigit(result[i])) result[i] = '*';

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После замены: {ArrayToString(result)}";
        }

        private string SolveTask2()
        {
            char[] array = GenerateCharArray(11);
            char[] result = (char[])array.Clone();

            for (int i = 0; i < 11; i++)
                if (char.IsLower(result[i])) result[i] = char.ToUpper(result[i]);

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После преобразования: {ArrayToString(result)}";
        }

        private string SolveTask3()
        {
            char[] array = GenerateCharArray(12);
            char[] result = (char[])array.Clone();

            for (int i = 0; i < 12; i++)
                if (char.IsDigit(result[i])) result[i] = '!';

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После замены: {ArrayToString(result)}";
        }

        private string SolveTask4()
        {
            char[] array = GenerateCharArray(10);
            char[] result = (char[])array.Clone();

            for (int i = 1; i < 10; i++)
                if (char.IsLower(result[i]) && result[i] >= 'a' && result[i] <= 'z')
                    result[i - 1] = ' ';

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После замены: {ArrayToString(result)}";
        }

        private string SolveTask5()
        {
            char[] array = GenerateCharArray(15);
            char[] result = (char[])array.Clone();

            for (int i = 0; i < 15; i++)
            {
                if (char.IsUpper(result[i]))
                    result[i] = char.ToLower(result[i]);
                else if (char.IsLower(result[i]))
                    result[i] = char.ToUpper(result[i]);
            }

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После смены регистра: {ArrayToString(result)}";
        }

        private string SolveTask6()
        {
            char[,] matrix = GenerateCharMatrix(2, 6);
            int plus = 0, minus = 0, star = 0;

            foreach (char c in matrix)
            {
                if (c == '+') plus++;
                else if (c == '-') minus++;
                else if (c == '*') star++;
            }

            return $"Матрица 2x6:\n{MatrixToString(matrix)}\n" +
                   $"'+': {plus}, '-': {minus}, '*': {star}";
        }

        private string SolveTask7()
        {
            char[] array = GenerateCharArray(15);
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            int count = array.Count(c => vowels.Contains(char.ToLower(c)));

            return $"Массив: {ArrayToString(array)}\n" +
                   $"Гласных русских букв: {count}";
        }

        private string SolveTask8()
        {
            char[] array = GenerateCharArray(10);
            array[rnd.Next(10)] = ':'; 
            int index = Array.IndexOf(array, ':');

            return $"Массив: {ArrayToString(array)}\n" +
                   $"Символов до ':': {(index >= 0 ? index : 0)}";
        }

        private string SolveTask9()
        {
            string text = "This is a sample text with some words beginning with b like banana and boat";
            char[] array = text.ToCharArray();
            int count = 0;
            bool inWord = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLetter(array[i]))
                {
                    if (!inWord && char.ToLower(array[i]) == 'b')
                        count++;
                    inWord = true;
                }
                else
                {
                    inWord = false;
                }
            }

            return $"Текст: {text}\n" +
                   $"Слов на 'b': {count}";
        }

        private string SolveTask10()
        {
            char[] array = GenerateCharArray(20);
            int r = 0, k = 0, t = 0;

            foreach (char c in array)
            {
                if (char.ToLower(c) == 'r') r++;
                else if (char.ToLower(c) == 'k') k++;
                else if (char.ToLower(c) == 't') t++;
            }

            return $"Массив: {ArrayToString(array)}\n" +
                   $"r: {r}, k: {k}, t: {t}";
        }
        private string SolveTask11()
        {
            char[] array = GenerateCharArray(15);
            int star = 0, comma = 0, dot = 0;

            foreach (char c in array)
            {
                if (c == '*') star++;
                else if (c == ',') comma++;
                else if (c == '.') dot++;
            }

            return $"Массив: {ArrayToString(array)}\n" +
                   $"*: {star}, ',': {comma}, '.': {dot}";
        }

        private string SolveTask12()
        {
            char[] array = GenerateCharArray(15);
            array[rnd.Next(array.Length)] = '#';
            int index = Array.IndexOf(array, '#');
            int countAfter = index >= 0 ? array.Length - index - 1 : 0;

            return $"Массив: {ArrayToString(array)}\n" +
                   $"Символов после '#': {countAfter}";
        }

        private string SolveTask13()
        {
            char[] array = "abc test abc123 abc abc xyzabc".ToCharArray();
            int count = 0;

            for (int i = 0; i <= array.Length - 3; i++)
            {
                if (array[i] == 'a' && array[i + 1] == 'b' && array[i + 2] == 'c')
                    count++;
            }

            return $"Текст: {ArrayToString(array)}\n" +
                   $"Групп 'abc': {count}";
        }

        private string SolveTask14()
        {
            char[] array = GenerateCharArray(20);
            array[3] = ':'; array[8] = ':'; array[15] = ':';
            char[] result = (char[])array.Clone();
            int replaceCount = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == ':')
                {
                    result[i] = ';';
                    replaceCount++;
                }
            }

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После замены: {ArrayToString(result)}\n" +
                   $"Количество замен: {replaceCount}";
        }

        private string SolveTask15()
        {
            char[] array = GenerateCharArray(15);
            array[2] = ':'; array[7] = ':';
            List<char> result = new List<char>();
            int removeCount = 0;

            foreach (char c in array)
            {
                if (c != ':') result.Add(c);
                else removeCount++;
            }

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"После удаления: {ArrayToString(result.ToArray())}\n" +
                   $"Удалено двоеточий: {removeCount}";
        }

        private string SolveTask16()
        {
            char[] array = "Текст (содержащий) некоторые (фрагменты) в скобках".ToCharArray();
            List<char> result = new List<char>();
            bool inBrackets = false;

            foreach (char c in array)
            {
                if (c == '(') inBrackets = true;
                else if (c == ')') inBrackets = false;
                else if (!inBrackets) result.Add(c);
            }

            return $"Исходный текст: {ArrayToString(array)}\n" +
                   $"Без скобок: {ArrayToString(result.ToArray())}";
        }

        private string SolveTask17()
        {
            char[] array = GenerateCharArray(20);
            array[10] = '$';
            int dollarIndex = Array.IndexOf(array, '$');
            int before = dollarIndex >= 0 ? dollarIndex : 0;
            int after = dollarIndex >= 0 ? array.Length - dollarIndex - 1 : 0;

            return $"Массив: {ArrayToString(array)}\n" +
                   $"Символов до '$': {before}\n" +
                   $"Символов после '$': {after}";
        }

        private string SolveTask18()
        {
            char[] array = "abracadabra".ToCharArray();
            var uniqueChars = array
                .GroupBy(c => c)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key);

            return $"Исходная строка: {ArrayToString(array)}\n" +
                   $"Уникальные символы: {string.Join(" ", uniqueChars)}";
        }

        private string SolveTask19()
        {
            char[] array = "int[] arr = new int[10]; arr[0] = 1;".ToCharArray();
            int open = array.Count(c => c == '[');
            int close = array.Count(c => c == ']');

            return $"Код: {ArrayToString(array)}\n" +
                   $"Открывающих скобок [: {open}\n" +
                   $"Закрывающих скобок ]: {close}\n" +
                   $"{(open == close ? "Количество совпадает" : "Количество не совпадает")}";
        }

        private string SolveTask20()
        {
            char[,] matrix = GenerateCharMatrix(3, 4);
            matrix[1, 2] = '@'; matrix[0, 0] = '@';
            int count = 0;

            foreach (char c in matrix)
                if (c == '@') count++;

            return $"Матрица 3x4:\n{MatrixToString(matrix)}\n" +
                   $"Символов @: {count}";
        }
        private string SolveTask21()
        {
            char[,] matrix = GenerateCharMatrix(5, 4);
            int plusCount = 0, starCount = 0;

            foreach (char c in matrix)
            {
                if (c == '+') plusCount++;
                else if (c == '*') starCount++;
            }

            return $"Матрица 5x4:\n{MatrixToString(matrix)}\n" +
                   $"Символов '+': {plusCount}\n" +
                   $"Символов '*': {starCount}";
        }

        private string SolveTask22()
        {
            char[] array = GenerateCharArray(12);
            char[] result = new char[12];

            for (int i = 0; i < 12; i++)
            {
                result[i] = (char)(array[i] * 2);
            }

            return $"Исходный массив: {ArrayToString(array)}\n" +
                   $"Коды удвоены: {ArrayToString(result)}\n" +
                   $"Шестнадцатеричные коды: {string.Join(" ", result.Select(c => ((int)c).ToString("X4")))}";
        }

        private string SolveTask23()
        {
            char[,] matrix = GenerateCharMatrix(3, 4);
            int digitCount = 0;
            char[,] result = (char[,])matrix.Clone();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (char.IsDigit(result[i, j]))
                    {
                        digitCount++;
                        result[i, j] = '!';
                    }
                }
            }

            return $"Исходная матрица:\n{MatrixToString(matrix)}\n" +
                   $"Цифр найдено: {digitCount}\n" +
                   $"После замены:\n{MatrixToString(result)}";
        }

        private string SolveTask24()
        {
            char[,] matrix = GenerateCharMatrix(5, 5);
            string latinChars = "";

            foreach (char c in matrix)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    latinChars += c;
            }

            return $"Матрица 5x5:\n{MatrixToString(matrix)}\n" +
                   $"Латинские буквы: {latinChars}";
        }

        private string SolveTask25()
        {
            char[,] matrix = GenerateCharMatrix(5, 5);
            char[,] sortedMatrix = (char[,])matrix.Clone();

            for (int i = 0; i < 5; i++)
            {
                char[] row = new char[5];
                for (int j = 0; j < 5; j++)
                    row[j] = sortedMatrix[i, j];

                Array.Sort(row);

                for (int j = 0; j < 5; j++)
                    sortedMatrix[i, j] = row[j];
            }

            return $"Исходная матрица:\n{MatrixToString(matrix)}\n" +
                   $"После сортировки строк:\n{MatrixToString(sortedMatrix)}";
        }

        private string SolveTask26()
        {
            char[,] matrix = GenerateCharMatrix(4, 4);
            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                sum += matrix[i, i]; 
            }

            return $"Матрица 4x4:\n{MatrixToString(matrix)}\n" +
                   $"Сумма кодов главной диагонали: {sum}";
        }

        private string SolveTask27()
        {
            char[,] matrix = GenerateCharMatrix(5, 5);
            char maxChar = matrix[0, 0];

            foreach (char c in matrix)
            {
                if (c > maxChar)
                    maxChar = c;
            }

            return $"Матрица 5x5:\n{MatrixToString(matrix)}\n" +
                   $"Символ с наибольшим кодом: '{maxChar}' (код: {(int)maxChar})";
        }

        private string SolveTask28()
        {
            char[] array = "Текст. С точками. Разделенный. На части.".ToCharArray();
            List<char> result = new List<char>();

            foreach (char c in array)
            {
                if (c == '.')
                {
                    result.Add('.');
                    result.Add('.');
                    result.Add('.');
                }
                else
                {
                    result.Add(c);
                }
            }

            return $"Исходный текст: {ArrayToString(array)}\n" +
                   $"После замены точек: {ArrayToString(result.ToArray())}";
        }

        private string SolveTask29()
        {
            string text = "banana apple cherry date blueberry";
            char[] array = text.ToCharArray();
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, StringComparer.OrdinalIgnoreCase);

            return $"Исходный текст: {text}\n" +
                   $"Отсортированные слова: {string.Join(" ", words)}";
        }

        private string SolveTask30()
        {
            char[,] matrix = GenerateCharMatrix(5, 7);
            int sum = 0;

            foreach (char c in matrix)
            {
                if (char.IsDigit(c))
                {
                    sum += (int)char.GetNumericValue(c);
                }
            }

            return $"Матрица 5x7:\n{MatrixToString(matrix)}\n" +
                   $"Сумма цифр: {sum}";
        }
    }
}
