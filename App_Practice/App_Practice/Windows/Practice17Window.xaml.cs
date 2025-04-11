using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Practice17Window.xaml
    /// </summary>
    public partial class Practice17Window : Window
    {

        private Random rnd = new Random();

        public Practice17Window()
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
        private List<int[,]> ReadMatricesFromFile(string filePath)
        {
            var matrices = new List<int[,]>();
            var lines = File.ReadAllLines(filePath);
            int i = 0;
            while (i < lines.Length)
            {
                var dim = lines[i].Split(' ');
                int rows = int.Parse(dim[0]);
                int cols = int.Parse(dim[1]);
                i++;

                int[,] matrix = new int[rows, cols];
                for (int r = 0; r < rows; r++)
                {
                    var row = lines[i].Split(' ');
                    for (int c = 0; c < cols; c++)
                    {
                        matrix[r, c] = int.Parse(row[c]);
                    }
                    i++;
                }
                matrices.Add(matrix);
            }
            return matrices;
        }
        private int[,] InverseMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[,] inverse = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    inverse[i, j] = matrix[j, i];
                }
            }

            return inverse;
        }

        private void WriteMatricesToFile(string filePath, List<int[,]> matrices)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var matrix in matrices)
                {
                    writer.WriteLine($"{matrix.GetLength(0)} {matrix.GetLength(1)}");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            writer.Write(matrix[i, j] + " ");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private string MatrixToString(int[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }

        private int[,] MultiplyMatrices(int[,] a, int[,] b)
        {
            int aRows = a.GetLength(0);
            int aCols = a.GetLength(1);
            int bCols = b.GetLength(1);
            int[,] result = new int[aRows, bCols];

            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < bCols; j++)
                {
                    for (int k = 0; k < aCols; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        private int SumDiagonal(int[,] matrix)
        {
            int sum = 0;
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        private int SumFirstRow(int[,] matrix)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[0, j];
            }
            return sum;
        }

        private int[,] CreateIdentityMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 1;
            }
            return matrix;
        }

        private int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        private bool IsSymmetric(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
                return false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }

        private bool MatricesEqual(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
                return false;

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (m1[i, j] != m2[i, j])
                        return false;
                }
            }
            return true;
        }

        private int CalculateDeterminant(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            if (n == 1) return matrix[0, 0];
            if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            int det = 0;
            for (int j = 0; j < n; j++)
            {
                int[,] minor = new int[n - 1, n - 1];
                for (int i = 1; i < n; i++)
                {
                    for (int k = 0, l = 0; k < n; k++)
                    {
                        if (k == j) continue;
                        minor[i - 1, l++] = matrix[i, k];
                    }
                }
                det += (j % 2 == 0 ? 1 : -1) * matrix[0, j] * CalculateDeterminant(minor);
            }
            return det;
        }

        private string SolveTask1()
        {
            string file1 = "task17_1_1.txt";
            string file2 = "task17_1_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n0 1\n2 3\n3 3\n1 0 0\n0 1 0\n0 0 1");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n1 2\n3 4");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toMove = m1.Where(mat => mat[0, 0] == 0).ToList();
            m1 = m1.Except(toMove).ToList();
            m2.AddRange(toMove);

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask2()
        {
            string file1 = "task17_2_1.txt";
            string file2 = "task17_2_2.txt";
            string extraFile = "task17_2_extra.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8\n2 2\n9 10\n11 12");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            List<int[,]> extra;

            if (m1.Count > m2.Count)
            {
                extra = m1.Skip(m2.Count).ToList();
                m1 = m1.Take(m2.Count).ToList();
            }
            else
            {
                extra = m2.Skip(m1.Count).ToList();
                m2 = m2.Take(m1.Count).ToList();
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);
            WriteMatricesToFile(extraFile, extra);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString)) +
                   "\n\nЛишние матрицы:\n" + string.Join("\n\n", extra.Select(MatrixToString));
        }

        private string SolveTask3()
        {
            string inputFile = "task17_3_input.txt";
            string outputFile = "task17_3_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8\n3 3\n1 0 0\n0 1 0\n0 0 1");

            var matrices = ReadMatricesFromFile(inputFile);
            var products = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i += 2)
            {
                if (i + 1 < matrices.Count)
                {
                    products.Add(MultiplyMatrices(matrices[i], matrices[i + 1]));
                }
            }

            WriteMatricesToFile(outputFile, products);

            return "Результаты умножения:\n" + string.Join("\n\n", products.Select(MatrixToString));
        }

        private string SolveTask4()
        {
            string file1 = "task17_4_1.txt";
            string file2 = "task17_4_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n5 6\n7 8");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var unique = m1.Where(mat1 => !m2.Any(mat2 => MatricesEqual(mat1, mat2))).ToList();
            m2.AddRange(unique);

            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask5()
        {
            string systemsFile = "task17_5_systems.txt";
            string solutionsFile = "task17_5_solutions.txt";

            if (!File.Exists(systemsFile)) File.WriteAllText(systemsFile, "3 4\n2 1 -1 8\n-3 -1 2 -11\n-2 1 2 -3");
            if (!File.Exists(solutionsFile)) File.WriteAllText(solutionsFile, "3 1\n2\n3\n-1");

            var systems = ReadMatricesFromFile(systemsFile);
            var solutions = ReadMatricesFromFile(solutionsFile);
            string result = "";

            for (int i = 0; i < systems.Count; i++)
            {
                result += $"Система {i + 1}:\n";
                for (int r = 0; r < systems[i].GetLength(0); r++)
                {
                    string eq = "";
                    for (int c = 0; c < systems[i].GetLength(1) - 1; c++)
                    {
                        eq += $"{systems[i][r, c]}x{c + 1} + ";
                    }
                    result += eq.TrimEnd('+', ' ') + $" = {systems[i][r, systems[i].GetLength(1) - 1]}\n";
                }
                result += "Решение: (" + string.Join(", ",
                    Enumerable.Range(0, solutions[i].GetLength(0)).Select(x => solutions[i][x, 0])) + ")\n\n";
            }

            return result;
        }

        private string SolveTask6()
        {
            string inputFile = "task17_6_input.txt";
            string outputFile = "task17_6_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "2 2\n1 2\n3 4\n3 3\n2 4 6\n1 3 5\n8 10 12");

            var matrices = ReadMatricesFromFile(inputFile);
            var evenSum = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i++)
            {
                int sum = 0;
                for (int r = 0; r < matrices[i].GetLength(0); r++)
                {
                    for (int c = 0; c < matrices[i].GetLength(1); c++)
                    {
                        if (matrices[i][r, c] > 0 && matrices[i][r, c] % 2 == 0)
                            sum += matrices[i][r, c];
                    }
                }
                if (sum % 2 == 0)
                {
                    evenSum.Add(matrices[i]);
                    matrices[i] = CreateIdentityMatrix(matrices[i].GetLength(0));
                }
            }

            WriteMatricesToFile(inputFile, matrices);
            WriteMatricesToFile(outputFile, evenSum);

            return "Измененные матрицы:\n" + string.Join("\n\n", matrices.Select(MatrixToString)) +
                   "\n\nМатрицы с четной суммой:\n" + string.Join("\n\n", evenSum.Select(MatrixToString));
        }

        private string SolveTask7()
        {
            string file1 = "task17_7_1.txt";
            string file2 = "task17_7_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int min = Math.Min(m1.Count, m2.Count);

            for (int i = 0; i < min; i++)
            {
                if (i % 2 == 0) 
                {
                    var temp = m1[i];
                    m1[i] = m2[i];
                    m2[i] = temp;
                }
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask8()
        {
            string file1 = "task17_8_1.txt";
            string file2 = "task17_8_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int size = m1[0].GetLength(0);

            if (m1.Count < m2.Count)
            {
                int diff = m2.Count - m1.Count;
                for (int i = 0; i < diff; i++)
                {
                    m1.Add(CreateIdentityMatrix(size));
                }
            }
            else if (m2.Count < m1.Count)
            {
                int diff = m1.Count - m2.Count;
                for (int i = 0; i < diff; i++)
                {
                    m2.Add(CreateIdentityMatrix(size));
                }
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask9()
        {
            string inputFile = "task17_9_input.txt";
            string outputFile = "task17_9_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "3 3\n1 2 3\n4 5 6\n7 8 9\n2 2\n1 0\n0 1");

            var matrices = ReadMatricesFromFile(inputFile);
            var oddSum = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i++)
            {
                int sum = SumDiagonal(matrices[i]);
                if (sum % 2 != 0)
                {
                    oddSum.Add(matrices[i]);
                    matrices[i] = TransposeMatrix(matrices[i]);
                }
            }

            WriteMatricesToFile(inputFile, matrices);
            WriteMatricesToFile(outputFile, oddSum);

            return "Измененные матрицы:\n" + string.Join("\n\n", matrices.Select(MatrixToString)) +
                   "\n\nМатрицы с нечетной суммой диагонали:\n" + string.Join("\n\n", oddSum.Select(MatrixToString));
        }

        private string SolveTask10()
        {
            string inputFile = "task17_10_input.txt";
            string symFile = "task17_10_symmetric.txt";
            string nonSymFile = "task17_10_nonsymmetric.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "3 3\n1 2 3\n2 5 6\n3 6 9\n2 2\n1 2\n3 4");

            var matrices = ReadMatricesFromFile(inputFile);
            var symmetric = matrices.Where(IsSymmetric).ToList();
            var nonSymmetric = matrices.Except(symmetric).ToList();

            WriteMatricesToFile(symFile, symmetric);
            WriteMatricesToFile(nonSymFile, nonSymmetric);

            return "Симметричные матрицы:\n" + string.Join("\n\n", symmetric.Select(MatrixToString)) +
                   "\n\nНесимметричные матрицы:\n" + string.Join("\n\n", nonSymmetric.Select(MatrixToString));
        }
        private string SolveTask11()
        {
            string file1 = "task17_11_1.txt";
            string file2 = "task17_11_2.txt";
            string outputFile = "task17_11_output.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var products = new List<int[,]>();

            for (int i = 0; i < Math.Min(m1.Count, m2.Count); i++)
            {
                products.Add(MultiplyMatrices(m1[i], m2[i]));
            }

            WriteMatricesToFile(outputFile, products);

            return "Произведения матриц:\n" + string.Join("\n\n", products.Select(MatrixToString));
        }

        private string SolveTask12()
        {
            string file1 = "task17_12_1.txt";
            string file2 = "task17_12_2.txt";
            string extraFile = "task17_12_extra.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8\n2 2\n9 10\n11 12");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int min = Math.Min(m1.Count, m2.Count);

            for (int i = 0; i < min; i++)
            {
                if (i % 2 == 0)
                {
                    var temp = m1[i];
                    m1[i] = m2[i];
                    m2[i] = temp;
                }
            }

            List<int[,]> remaining;
            if (m1.Count > m2.Count)
            {
                remaining = m1.Skip(min).ToList();
                m1 = m1.Take(min).ToList();
            }
            else
            {
                remaining = m2.Skip(min).ToList();
                m2 = m2.Take(min).ToList();
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);
            WriteMatricesToFile(extraFile, remaining);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString)) +
                   "\n\nОставшиеся матрицы:\n" + string.Join("\n\n", remaining.Select(MatrixToString));
        }

        private string SolveTask13()
        {
            string file1 = "task17_13_1.txt";
            string file2 = "task17_13_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n3 3\n1 0 0\n0 1 0\n0 0 1");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n5 6\n7 8");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toMove = m1.Where(mat => SumDiagonal(mat) == 5).ToList();
            m1 = m1.Except(toMove).ToList();
            m2.AddRange(toMove);

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask14()
        {
            string file1 = "task17_14_1.txt";
            string file2 = "task17_14_2.txt";
            string extraFile = "task17_14_extra.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            List<int[,]> extra;

            if (m1.Count < m2.Count)
            {
                extra = m1.Skip(m2.Count).ToList();
                m1 = m1.Take(m2.Count).ToList();
            }
            else
            {
                extra = m2.Skip(m1.Count).ToList();
                m2 = m2.Take(m1.Count).ToList();
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);
            WriteMatricesToFile(extraFile, extra);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString)) +
                   "\n\nЛишние матрицы:\n" + string.Join("\n\n", extra.Select(MatrixToString));
        }

        private string SolveTask15()
        {
            string inputFile = "task17_15_input.txt";
            string outputFile = "task17_15_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");

            var matrices = ReadMatricesFromFile(inputFile);
            var sums = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i += 2)
            {
                if (i + 1 < matrices.Count)
                {
                    var sum = new int[matrices[i].GetLength(0), matrices[i].GetLength(1)];
                    for (int r = 0; r < matrices[i].GetLength(0); r++)
                    {
                        for (int c = 0; c < matrices[i].GetLength(1); c++)
                        {
                            sum[r, c] = matrices[i][r, c] + matrices[i + 1][r, c];
                        }
                    }
                    sums.Add(sum);
                }
            }

            WriteMatricesToFile(outputFile, sums);

            return "Суммы матриц:\n" + string.Join("\n\n", sums.Select(MatrixToString));
        }

        private string SolveTask16()
        {
            string file1 = "task17_16_1.txt";
            string file2 = "task17_16_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n3 3\n1 0 0\n0 1 0\n0 0 1");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n5 6\n7 8");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toAdd = m1.Where(mat => CalculateDeterminant(mat) == 5).ToList();
            m2.AddRange(toAdd);

            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask17()
        {
            string systemsFile = "task17_17_systems.txt";
            string vectorsFile = "task17_17_vectors.txt";

            if (!File.Exists(systemsFile)) File.WriteAllText(systemsFile, "3 4\n2 1 -1 8\n-3 -1 2 -11\n-2 1 2 -3");
            if (!File.Exists(vectorsFile)) File.WriteAllText(vectorsFile, "3 1\n2\n3\n-1");

            var systems = ReadMatricesFromFile(systemsFile);
            var vectors = ReadMatricesFromFile(vectorsFile);
            string result = "";

            for (int i = 0; i < systems.Count; i++)
            {
                result += $"Система {i + 1}:\n";
                for (int r = 0; r < systems[i].GetLength(0); r++)
                {
                    string eq = "";
                    for (int c = 0; c < systems[i].GetLength(1) - 1; c++)
                    {
                        eq += $"{systems[i][r, c]}x{c + 1} + ";
                    }
                    result += eq.TrimEnd('+', ' ') + $" = {systems[i][r, systems[i].GetLength(1) - 1]}\n";
                }

                int[,] product = MultiplyMatrices(systems[i], vectors[i]);
                result += "Произведение: (" + string.Join(", ",
                    Enumerable.Range(0, product.GetLength(0)).Select(x => product[x, 0])) + ")\n\n";
            }

            return result;
        }

        private string SolveTask18()
        {
            string inputFile = "task17_18_input.txt";
            string outputFile = "task17_18_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "2 2\n-1 2\n3 -5\n3 3\n2 -4 6\n1 3 -5\n8 10 -12");

            var matrices = ReadMatricesFromFile(inputFile);
            var oddSum = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i++)
            {
                int sum = 0;
                for (int r = 0; r < matrices[i].GetLength(0); r++)
                {
                    for (int c = 0; c < matrices[i].GetLength(1); c++)
                    {
                        if (matrices[i][r, c] < 0 && matrices[i][r, c] % 2 != 0)
                            sum += matrices[i][r, c];
                    }
                }
                if (sum % 2 != 0)
                {
                    oddSum.Add(matrices[i]);
                    matrices[i] = CreateIdentityMatrix(matrices[i].GetLength(0));
                }
            }

            WriteMatricesToFile(inputFile, matrices);
            WriteMatricesToFile(outputFile, oddSum);

            return "Измененные матрицы:\n" + string.Join("\n\n", matrices.Select(MatrixToString)) +
                   "\n\nМатрицы с нечетной суммой:\n" + string.Join("\n\n", oddSum.Select(MatrixToString));
        }

        private string SolveTask19()
        {
            string file1 = "task17_19_1.txt";
            string file2 = "task17_19_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int min = Math.Min(m1.Count, m2.Count);

            for (int i = 0; i < min; i++)
            {
                if (i % 2 == 1) 
                {
                    var temp = m1[i];
                    m1[i] = m2[i];
                    m2[i] = temp;
                }
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask20()
        {
            string file1 = "task17_20_1.txt";
            string file2 = "task17_20_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n5 6\n7 8\n2 2\n9 10\n11 12");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int size = m1[0].GetLength(0);

            if (m1.Count < m2.Count)
            {
                int diff = m2.Count - m1.Count;
                for (int i = 0; i < diff; i++)
                {
                    m1.Insert(0, CreateIdentityMatrix(size));
                }
            }
            else if (m2.Count < m1.Count)
            {
                int diff = m1.Count - m2.Count;
                for (int i = 0; i < diff; i++)
                {
                    m2.Insert(0, CreateIdentityMatrix(size));
                }
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask21()
        {
            string inputFile = "task17_21_input.txt";
            string outputFile = "task17_21_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "3 3\n1 2 3\n4 5 6\n7 8 9\n2 2\n5 0\n0 3");

            var matrices = ReadMatricesFromFile(inputFile);
            var evenDiff = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i++)
            {
                int diff = matrices[i][0, 0] - matrices[i][matrices[i].GetLength(0) - 1, matrices[i].GetLength(1) - 1];
                if (diff % 2 == 0)
                {
                    evenDiff.Add(matrices[i]);
                    matrices[i] = TransposeMatrix(matrices[i]);
                }
            }

            WriteMatricesToFile(inputFile, matrices);
            WriteMatricesToFile(outputFile, evenDiff);

            return "Измененные матрицы:\n" + string.Join("\n\n", matrices.Select(MatrixToString)) +
                   "\n\nМатрицы с четной разностью:\n" + string.Join("\n\n", evenDiff.Select(MatrixToString));
        }

        private string SolveTask22()
        {
            string inputFile = "task17_22_input.txt";
            string symFile = "task17_22_symmetric.txt";
            string nonSymFile = "task17_22_nonsymmetric.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "3 3\n1 2 3\n2 5 6\n3 6 9\n2 2\n1 2\n3 4");

            var matrices = ReadMatricesFromFile(inputFile);
            var inverse = matrices.Where(mat => {
                try { return MatricesEqual(mat, InverseMatrix(mat)); }
                catch { return false; }
            }).ToList();
            var others = matrices.Except(inverse).ToList();

            WriteMatricesToFile(symFile, inverse);
            WriteMatricesToFile(nonSymFile, others);

            return "Обратные матрицы:\n" + string.Join("\n\n", inverse.Select(MatrixToString)) +
                   "\n\nОстальные матрицы:\n" + string.Join("\n\n", others.Select(MatrixToString));
        }

        private string SolveTask23()
        {
            string file1 = "task17_23_1.txt";
            string file2 = "task17_23_2.txt";
            string outputFile = "task17_23_output.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var results = new List<string>();

            for (int i = 0; i < Math.Min(m1.Count, m2.Count); i++)
            {
                results.Add($"Матрица 1:\n{MatrixToString(m1[i])}");
                results.Add($"Матрица 2:\n{MatrixToString(m2[i])}");
                var product = MultiplyMatrices(m1[i], m2[i]);
                results.Add($"Произведение:\n{MatrixToString(product)}");
            }

            File.WriteAllLines(outputFile, results);

            return string.Join("\n\n", results);
        }

        private string SolveTask24()
        {
            string file1 = "task17_24_1.txt";
            string file2 = "task17_24_2.txt";
            string extraFile = "task17_24_extra.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8\n2 2\n9 10\n11 12");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            int min = Math.Min(m1.Count, m2.Count);

            for (int i = 0; i < min; i++)
            {
                if ((i + 1) % 2 == 0) // четные по порядку (индексация с 1)
                {
                    var temp = m1[i];
                    m1[i] = m2[i];
                    m2[i] = temp;
                }
            }

            List<int[,]> remaining;
            if (m1.Count > m2.Count)
            {
                remaining = m1.Skip(min).ToList();
                m1 = m1.Take(min).ToList();
            }
            else
            {
                remaining = m2.Skip(min).ToList();
                m2 = m2.Take(min).ToList();
            }

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);
            WriteMatricesToFile(extraFile, remaining);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString)) +
                   "\n\nОставшиеся матрицы:\n" + string.Join("\n\n", remaining.Select(MatrixToString));
        }

        private string SolveTask25()
        {
            string file1 = "task17_25_1.txt";
            string file2 = "task17_25_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n6 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toMove = m1.Where(mat => SumFirstRow(mat) > 5).ToList();
            m1 = m1.Except(toMove).ToList();
            m2.AddRange(toMove);

            WriteMatricesToFile(file1, m1);
            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask26()
        {
            string file1 = "task17_26_1.txt";
            string file2 = "task17_26_2.txt";
            string outputFile = "task17_26_output.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "2 2\n1 2\n3 4\n2 2\n5 6\n7 8");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12\n2 2\n13 14\n15 16");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var products = new List<int[,]>();

            for (int i = 0; i < Math.Min(m1.Count, m2.Count); i++)
            {
                products.Add(MultiplyMatrices(m1[i], m2[i]));
            }

            WriteMatricesToFile(outputFile, products);

            return "Произведения матриц:\n" + string.Join("\n\n", products.Select(MatrixToString));
        }

        private string SolveTask27()
        {
            string inputFile = "task17_27_input.txt";
            string outputFile = "task17_27_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "2 2\n1 2\n3 4\n2 2\n1 5\n3 7\n3 3\n1 0 0\n0 1 0\n0 0 1");

            var matrices = ReadMatricesFromFile(inputFile);
            var filtered = new List<int[,]>();

            for (int i = 0; i < matrices.Count; i += 2)
            {
                if (i + 1 < matrices.Count)
                {
                    bool equal = true;
                    for (int r = 0; r < matrices[i].GetLength(0); r++)
                    {
                        if (matrices[i][r, 0] != matrices[i + 1][r, 0])
                        {
                            equal = false;
                            break;
                        }
                    }
                    if (equal)
                    {
                        filtered.Add(matrices[i]);
                        filtered.Add(matrices[i + 1]);
                    }
                }
            }

            WriteMatricesToFile(outputFile, filtered);

            return "Отфильтрованные матрицы:\n" + string.Join("\n\n", filtered.Select(MatrixToString));
        }

        private string SolveTask28()
        {
            string file1 = "task17_28_1.txt";
            string file2 = "task17_28_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "3 3\n5 2 3\n4 5 6\n7 8 5\n2 2\n1 2\n3 1");
            if (!File.Exists(file2)) File.WriteAllText(file2, "2 2\n9 10\n11 12");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toAdd = m1.Where(mat => {
                int first = mat[0, 0];
                for (int i = 1; i < Math.Min(mat.GetLength(0), mat.GetLength(1)); i++)
                {
                    if (mat[i, i] != first) return false;
                }
                return true;
            }).ToList();
            m2.AddRange(toAdd);

            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }

        private string SolveTask29()
        {
            string inputFile = "task17_29_input.txt";
            string outputFile = "task17_29_output.txt";

            if (!File.Exists(inputFile)) File.WriteAllText(inputFile, "3 3\n1 2 3\n4 5 6\n7 8 9\n2 2\n2 1\n1 2");

            var matrices = ReadMatricesFromFile(inputFile);
            var filtered = new List<int[,]>();

            foreach (var mat in matrices)
            {
                int product = 1;
                int size = Math.Min(mat.GetLength(0), mat.GetLength(1));
                for (int i = 0; i < size; i++)
                {
                    product *= mat[i, i] * mat[i, size - 1 - i];
                }
                if (product > 15)
                {
                    filtered.Add(mat);
                }
            }

            WriteMatricesToFile(outputFile, filtered);

            return "Отфильтрованные матрицы:\n" + string.Join("\n\n", filtered.Select(MatrixToString));
        }

        private string SolveTask30()
        {
            string file1 = "task17_30_1.txt";
            string file2 = "task17_30_2.txt";

            if (!File.Exists(file1)) File.WriteAllText(file1, "3 3\n5 2 3\n4 5 6\n7 8 9\n2 2\n5 1\n3 2");
            if (!File.Exists(file2)) File.WriteAllText(file2, "3 3\n1 0 0\n0 1 0\n0 0 1\n2 2\n0 0\n0 0");

            var m1 = ReadMatricesFromFile(file1);
            var m2 = ReadMatricesFromFile(file2);
            var toUse = m1.Where(mat => mat[0, 0] == 5).Take(m2.Count).ToList();

            for (int i = 0; i < toUse.Count; i++)
            {
                int size = Math.Min(m2[i].GetLength(0), m2[i].GetLength(1));
                for (int j = 0; j < size; j++)
                {
                    m2[i][j, j] = toUse[i][j, j];
                }
            }

            WriteMatricesToFile(file2, m2);

            return "Файл 1:\n" + string.Join("\n\n", m1.Select(MatrixToString)) +
                   "\n\nФайл 2:\n" + string.Join("\n\n", m2.Select(MatrixToString));
        }
    }
}
