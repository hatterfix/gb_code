// Внутри класса Answer напишите методы 
//CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
//с каждым новым элементом увеличивающимся на определенное число.
// Метод принимает на вход три числа
// (n - количество строк матрицы, 
//m - количество столбцов матрицы, 
//k - число, на которое увеличивается каждый новый элемент) 
//и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран 
//сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] 
//и возвращает одномерный массив типа double.
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы 
//и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, 
//возвращенный методом FindAverageInColumns и выводит этот список на экран
// в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ...,
// где x.x0 - это значения средних значений столбцов, 
//округленные до двух знаков после запятой
// (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода)
//, разделенные знаком табуляции.

using System;

class Answer
{
    static void Main(string[] args)
    {
        int n = 3;
        int m = 4;
        int k = 2;

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int value = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }

        return matrix;
    }

    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static double[] FindAverageInColumns(int[,] matrix)
    {
        int m = matrix.GetLength(1);
        double[] averages = new double[m];

        for (int j = 0; j < m; j++)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }

            averages[j] = (double)sum / matrix.GetLength(0);
        }

        return averages;
    }

    public static void PrintListAvr(double[] list)
    {
        Console.WriteLine("The averages in columns are:");
        foreach (double average in list)
        {
            Console.Write(average.ToString("F2") + "\t");
        }
        Console.WriteLine();
    }
}