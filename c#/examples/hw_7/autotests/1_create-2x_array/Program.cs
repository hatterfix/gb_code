// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix,
// который принимал бы числа m и n (размерность массива), 
// а также minLimitRandom и maxLimitRandom, 
// которые указывают на минимальную и максимальную границы случайных чисел.


// Для метода CreateRandomMatrix:

// Введите свое решение ниже
    double[,] matrix = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
            }
        }

        return matrix;

//Для метода PrintArray, который выводил бы массив на экран с условиями.
// (Для вывода матрицы используйте интерполяцию строк
//  для форматирования числа matrix[i, j] с двумя знаками после запятой (f2)
//  и добавления символа табуляции (\t) после каждого элемента матрицы.
//  Таким образом, каждый элемент матрицы
// будет разделен символом табуляции  при выводе.)

      // Введите свое решение ниже
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        Console.WriteLine($"m = {m}, n = {n}");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j].ToString("f2")}\t");
            }

            Console.WriteLine();
        }