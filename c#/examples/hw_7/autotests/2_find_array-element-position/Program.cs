// Внутри класса Answer напишите методы 
//CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

//Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число.
// Метод принимает на вход три числа
// (n - количество строк матрицы, 
//m - количество столбцов матрицы, 
//k - число, на которое увеличивается каждый новый элемент)
// и возвращает матрицу, удовлетворяющую этим условиям.

//Метод PrintArray должен выводить на экран 
//сгенерированную методом CreateIncreasingMatrix матрицу.
// Элементы матрицы должны быть выведены через символ табуляции
// для более читаемого вывода.

//Метод FindNumberByPosition принимает на вход сгенерированную матрицу
// и числа x и y - позиции элемента в матрице. 
//Если указанные координаты находятся за пределами границ массива,
// метод должен вернуть массив с нулевым значением.
// Если координаты находятся в пределах границ,
// метод должен вернуть массив с двумя значениями:
// значением числа в указанной позиции,
// а второй элемент должен быть равен 0, 
//чтобы показать, что операция прошла успешно без ошибок.

//Метод PrintCheckIfError должен принимать 
//результат метода FindNumberByPosition и числа x и y
// - позиции элемента в матрице. 
//Метод должен проверить, был ли найден элемент в матрице
// по указанным координатам (x и y),
// используя результаты из метода FindNumberByPosition. 
//Если такого элемента нет,
// вывести на экран "There is no such index".
// Если элемент есть, вывести на экран
// "The number in [{x}, {y}] is {значение}".

    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
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
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
        if (rowPosition < 0 || rowPosition >= matrix.GetLength(0) || 
            columnPosition < 0 || columnPosition >= matrix.GetLength(1))
        {
            return new int[1]; // возвращаем пустой массив с нулевым значением
        }
        else
        {
            int[] result = new int[2];
            result[0] = matrix[rowPosition, columnPosition];
            result[1] = 0;
            return result;
        }

    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
        if (results.Length == 1)
        {
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
    }