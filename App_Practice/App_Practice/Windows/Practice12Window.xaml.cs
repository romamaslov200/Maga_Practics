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
    /// Логика взаимодействия для Practice12Window.xaml
    /// </summary>
    public partial class Practice12Window : Window
    {
        public Practice12Window()
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
        private string SolveTask1()
        {
            var points = new List<(double x, double y)>
            {
                (1, 2), (3, 4), (5, 6), (7, 8), (2, 5)
            };

            double radius = 5;
            (double x, double y) center = (3, 4);

            return $"Центр: ({center.x}, {center.y})\nРадиус: {radius}\nТочки: {string.Join(", ", points)}";
        }

        private string SolveTask2()
        {
            var students = new[] { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов" };
            var results = new[] { 12.5, 11.8, 12.1, 11.9, 12.3 };

            var best = students.Zip(results, (s, r) => new { Name = s, Result = r })
                             .OrderBy(x => x.Result)
                             .Take(4)
                             .Select(x => x.Name);

            return $"Лучшие бегуны:\n{string.Join("\n", best)}";
        }

        private string SolveTask3()
        {
            int size = 5;
            int[,] matrix = new int[size, size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next(1, 10);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = -3 * matrix[i, j];

            return MatrixToString(matrix);
        }

        private string SolveTask4()
        {
            int size = 5;
            int[,] matrix = new int[size, size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next(1, 10);

            var elements = new List<int>();
            for (int i = 1; i < size; i++)
                for (int j = 0; j < i; j++)
                    elements.Add(matrix[i, j]);

            elements.Sort();

            return $"Исходная матрица:\n{MatrixToString(matrix)}\n\nЭлементы ниже диагонали:\n{string.Join(" ", elements)}";
        }

        private string SolveTask5()
        {
            int size = 5;
            int[,] matrix = new int[size, size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next(1, 10);

            var arr = matrix.Cast<int>().ToArray();
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

            return $"Исходная матрица:\n{MatrixToString(matrix)}\n\nОтсортированный массив:\n{string.Join(" ", arr)}";
        }

        private string SolveTask6()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {5, 4, 3, 2, 1},
        {1, 2, 3, 4, 5},
        {9, 8, 7, 6, 5},
        {1, 3, 5, 7, 9}
    };

            var firstRowSet = new HashSet<int>();
            for (int j = 0; j < matrix.GetLength(1); j++)
                firstRowSet.Add(matrix[0, j]);

            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                var currentSet = new HashSet<int>();
                for (int j = 0; j < matrix.GetLength(1); j++)
                    currentSet.Add(matrix[i, j]);

                if (firstRowSet.SetEquals(currentSet))
                    count++;
            }

            return $"Количество строк, похожих на первую: {count}\n" +
                   $"Первая строка: {string.Join(", ", firstRowSet)}";
        }


        private string SolveTask7()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {11, 12, 13, 14, 15},
        {16, 17, 18, 19, 20},
        {21, 22, 23, 24, 25}
    };
            int k = 13;

            var positions = new List<string>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int last = matrix[i, matrix.GetLength(1) - 1];
                matrix[i, matrix.GetLength(1) - 1] = k;

                int j = 0;
                while (matrix[i, j] != k)
                    j++;

                matrix[i, matrix.GetLength(1) - 1] = last;

                if (j < matrix.GetLength(1) - 1 || matrix[i, matrix.GetLength(1) - 1] == k)
                    positions.Add($"Строка {i + 1}, Позиция {j + 1}");
            }

            return $"Элемент {k} найден в позициях:\n{string.Join("\n", positions)}";
        }

        private string SolveTask8()
        {
            int[,] matrix = {
        {5, 4, 3, 2, 1},
        {1, 2, 3, 4, 5},
        {9, 8, 7, 6, 5},
        {2, 4, 6, 8, 10},
        {3, 6, 9, 12, 15}
    };

            int minSum = int.MaxValue;
            int minRow = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum += matrix[i, j];

                if (sum < minSum)
                {
                    minSum = sum;
                    minRow = i;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] *= minSum;

            return $"Минимальная сумма в строке {minRow + 1}: {minSum}\n" +
                   $"Результирующая матрица:\n{MatrixToString(matrix)}";
        }

        private string SolveTask9()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 20},
        {5, 6, 7, 8, 15},
        {9, 10, 11, 12, 10},
        {13, 14, 15, 16, 5},
        {17, 18, 19, 20, 1}
    };

            var lastElements = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                lastElements[i] = matrix[i, matrix.GetLength(1) - 1];

            int max = lastElements.Max();
            int min = lastElements.Min();
            int[] count = new int[max - min + 1];

            foreach (int num in lastElements)
                count[num - min]++;

            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            int[] sortedIndices = new int[matrix.GetLength(0)];
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int num = lastElements[i];
                sortedIndices[count[num - min] - 1] = i;
                count[num - min]--;
            }

            string result = "Исходная матрица:\n" + MatrixToString(matrix);
            result += "\nОтсортированные строки:\n";

            foreach (int index in sortedIndices.Reverse())
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result += $"{matrix[index, j],3}";
                result += "\n";
            }

            return result;
        }

        private string SolveTask10()
        {
            int[,] matrix = {
        {5, 4, 3, 2, 1, 1, 2, 3, 4, 5},
        {4, 3, 2, 1, 0, 2, 3, 4, 5, 6},
        {3, 2, 1, 0, -1, 3, 4, 5, 6, 7},
        {2, 1, 0, -1, -2, 4, 5, 6, 7, 8},
        {1, 0, -1, -2, -3, 5, 6, 7, 8, 9}
    };

            int count = 0;
            var decreasingCols = new List<int>();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isDecreasing = true;
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isDecreasing = false;
                        break;
                    }
                }

                if (isDecreasing)
                {
                    count++;
                    decreasingCols.Add(j + 1);
                }
            }

            return $"Количество монотонно убывающих столбцов: {count}\n" +
                   $"Номера столбцов: {string.Join(", ", decreasingCols)}";
        }

        private string SolveTask11()
        {
            int[,] matrix = {
        {5, 4, 3, 2, 1},
        {10, 9, 8, 7, 6},
        {15, 14, 13, 12, 11},
        {20, 19, 18, 17, 16},
        {25, 24, 23, 22, 21}
    };

            int maxOfMin = int.MinValue;
            int resultRow = -1, resultCol = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int minInRow = matrix[i, 0];
                int minCol = 0;

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minInRow)
                    {
                        minInRow = matrix[i, j];
                        minCol = j;
                    }
                }

                if (minInRow > maxOfMin)
                {
                    maxOfMin = minInRow;
                    resultRow = i;
                    resultCol = minCol;
                }
            }

            return $"Максимальный из минимальных: {maxOfMin}\n" +
                   $"Позиция: строка {resultRow + 1}, столбец {resultCol + 1}";
        }

        private string SolveTask12()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {2, 3, 4, 5, 4},
        {3, 4, 5, 6, 3},
        {4, 5, 6, 7, 2},
        {5, 6, 7, 8, 1}
    };

            int maxElement = 0;
            var orderedCols = new List<int>();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool isIncreasing = true;
                bool isDecreasing = true;

                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] <= matrix[i - 1, j]) isIncreasing = false;
                    if (matrix[i, j] >= matrix[i - 1, j]) isDecreasing = false;
                }

                if (isIncreasing || isDecreasing)
                {
                    orderedCols.Add(j + 1);
                    int currentMax = matrix[0, j];
                    for (int i = 1; i < matrix.GetLength(0); i++)
                        if (matrix[i, j] > currentMax)
                            currentMax = matrix[i, j];

                    if (currentMax > maxElement)
                        maxElement = currentMax;
                }
            }

            if (orderedCols.Count == 0)
                return "Упорядоченные столбцы отсутствуют";

            return $"Максимальный элемент в упорядоченных столбцах: {maxElement}\n" +
                   $"Упорядоченные ст��лбцы: {string.Join(", ", orderedCols)}";
        }

        private string SolveTask13()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {11, 12, 13, 14, 15},
        {16, 17, 18, 19, 20},
        {21, 22, 23, 24, 25}
    };

            int n = matrix.GetLength(0);
            int[,] mirrored = (int[,])matrix.Clone();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    mirrored[i, j] = matrix[n - j - 1, n - i - 1];
                    mirrored[n - j - 1, n - i - 1] = matrix[i, j];
                }
            }

            return "Исходная матрица:\n" + MatrixToString(matrix) +
                   "\nОтраженная матрица:\n" + MatrixToString(mirrored);
        }

        private string SolveTask14()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {2, 3, 4, 5, 6},
        {3, 4, 5, 6, 7},
        {4, 5, 6, 7, 8},
        {5, 6, 7, 8, 9}
    };

            var uniqueElements = new HashSet<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    uniqueElements.Add(matrix[i, j]);

            return $"Уникальные элементы ({uniqueElements.Count}):\n" +
                   string.Join(", ", uniqueElements.OrderBy(x => x));
        }

        private string SolveTask15()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {11, 12, 13, 14, 15},
        {16, 17, 18, 19, 20},
        {21, 22, 23, 24, 25}
    };

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                sum += matrix[i, i];

            return $"Сумма элементов главной диагонали: {sum}\n" +
                   $"Элементы: {string.Join(" + ", Enumerable.Range(0, matrix.GetLength(0)).Select(i => matrix[i, i]))} = {sum}";
        }

        private string SolveTask16()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {11, 12, 13, 14, 15},
        {16, 17, 18, 19, 20},
        {21, 22, 23, 24, 25}
    };

            int sum = 0;
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
                sum += matrix[i, n - 1 - i];

            return $"Сумма элементов побочной диагонали: {sum}\n" +
                   $"Элементы: {string.Join(" + ", Enumerable.Range(0, n).Select(i => matrix[i, n - 1 - i]))} = {sum}";
        }

        private string SolveTask17()
        {
            int[,] matrix = {
        {5, 4, 3, 2, 1},
        {10, 9, 8, 7, 6},
        {15, 14, 13, 12, 11},
        {20, 19, 18, 17, 16},
        {25, 24, 23, 22, 21}
    };

            int max = matrix[0, 0];
            var positions = new List<string>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        positions.Clear();
                        positions.Add($"({i + 1},{j + 1})");
                    }
                    else if (matrix[i, j] == max)
                    {
                        positions.Add($"({i + 1},{j + 1})");
                    }
                }
            }

            return $"Максимальный элемент: {max}\n" +
                   $"Позиции: {string.Join(", ", positions)}";
        }


        private string SolveTask18()
        {
            int[,] matrix = {
        {5, 4, 3, 2, 1},
        {10, 9, 8, 7, 6},
        {15, 14, 13, 12, 11},
        {20, 19, 18, 17, 16},
        {25, 24, 23, 22, 21}
    };

            int min = matrix[0, 0];
            var positions = new List<string>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        positions.Clear();
                        positions.Add($"({i + 1},{j + 1})");
                    }
                    else if (matrix[i, j] == min)
                    {
                        positions.Add($"({i + 1},{j + 1})");
                    }
                }
            }

            return $"Минимальный элемент: {min}\n" +
                   $"Позиции: {string.Join(", ", positions)}";
        }

        private string SolveTask19()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {6, 7, 8, 9, 10},
        {11, 12, 13, 14, 15},
        {16, 17, 18, 19, 20},
        {21, 22, 23, 24, 25}
    };

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum += matrix[i, j];

            return $"Сумма всех элементов матрицы: {sum}";
        }

        private string MatrixToString(int[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += $"{matrix[i, j],3}";
                }
                result += "\n";
            }
            return result;
        }
        private string SolveTask20()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return $"Количество четных элементов: {count}";
        }

        private string SolveTask21()
        {
            int n = 2;
            int size = 2 * n + 1;
            int[,] spiral = new int[size, size];

            int value = (int)Math.Pow(2 * n + 1, 2) - 1;
            int x = n, y = n;
            int dir = 0;
            int step = 1;
            int stepCount = 0;

            spiral[x, y] = 0;

            while (value > 0)
            {
                for (int i = 0; i < step; i++)
                {
                    switch (dir)
                    {
                        case 0: y--; break;
                        case 1: x++; break;
                        case 2: y++; break;
                        case 3: x--; break;
                    }

                    if (x >= 0 && x < size && y >= 0 && y < size)
                    {
                        spiral[x, y] = value--;
                    }
                }

                dir = (dir + 1) % 4;
                stepCount++;
                if (stepCount % 2 == 0) step++;
            }

            string result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += $"{spiral[i, j],3}";
                }
                result += "\n";
            }

            return result;
        }

        private string SolveTask22()
        {
            int[,] matrix = {
        {5, 3, 8, 1, 7, 2, 9, 4},
        {2, 7, 1, 9, 4, 6, 3, 8},
        {9, 4, 6, 3, 8, 5, 2, 7},
        {1, 8, 3, 7, 2, 9, 4, 6},
        {7, 2, 9, 4, 6, 1, 8, 3},
        {3, 6, 4, 8, 1, 7, 5, 2},
        {8, 1, 7, 5, 3, 2, 6, 9},
        {4, 9, 2, 6, 5, 8, 7, 1}
    };

            int size = matrix.GetLength(0);
            int[] diagonal = new int[size];
            for (int i = 0; i < size; i++)
            {
                diagonal[i] = matrix[i, size - 1 - i];
            }

            Array.Sort(diagonal);

            int[,] sortedMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int newRow = Array.IndexOf(diagonal, matrix[i, size - 1 - i]);
                for (int j = 0; j < size; j++)
                {
                    sortedMatrix[newRow, j] = matrix[i, j];
                }
            }

            return "Исходная матрица:\n" + MatrixToString(matrix) +
                   "\nОтсортированная матрица:\n" + MatrixToString(sortedMatrix);
        }

        private string SolveTask23()
        {
            int n = 4;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) matrix[i, j] = 1;
                    else if (i < j) matrix[i, j] = 0;
                    else matrix[i, j] = 2;
                }
            }

            return MatrixToString(matrix);
        }

        private string SolveTask24()
        {
            int[,] matrix = new int[5, 5];
            int center = 2;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == center || j == center)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return MatrixToString(matrix);
        }

        private string SolveTask25()
        {
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0 || i == 2 || j == 2)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return MatrixToString(matrix);
        }

        private string SolveTask26()
        {
            int[,] matrix = new int[5, 5];
            int center = 2;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Math.Abs(i - center) + Math.Abs(j - center) <= 2)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return MatrixToString(matrix);
        }

        private string SolveTask27()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {5, 4, 3, 2, 1},
        {1, 2, 3, 4, 5},
        {9, 8, 7, 6, 5},
        {1, 3, 5, 7, 9}
    };

            var firstRowSet = new HashSet<int>();
            for (int j = 0; j < matrix.GetLength(1); j++)
                firstRowSet.Add(matrix[0, j]);

            int count = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                var currentSet = new HashSet<int>();
                for (int j = 0; j < matrix.GetLength(1); j++)
                    currentSet.Add(matrix[i, j]);

                if (firstRowSet.SetEquals(currentSet))
                    count++;
            }

            return $"Количество строк, похожих на первую: {count}";
        }

        private string SolveTask28()
        {
            int[,] matrix = {
        {1, 2, 3, 4, 5},
        {5, 4, 3, 2, 1},
        {1, 2, 3, 4, 5},
        {9, 8, 7, 6, 5},
        {1, 3, 5, 7, 9}
    };

            int lastCol = matrix.GetLength(1) - 1;
            var lastColSet = new HashSet<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
                lastColSet.Add(matrix[i, lastCol]);

            int count = 0;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                var currentSet = new HashSet<int>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                    currentSet.Add(matrix[i, j]);

                if (lastColSet.SetEquals(currentSet))
                    count++;
            }

            return $"Количество столбцов, похожих на последний: {count}";
        }

        private string SolveTask29()
        {
            return SolveTask28();
        }

        private string SolveTask30()
        {
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return MatrixToString(matrix);
        }
    }
}
