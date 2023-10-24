// Работа с вещественными числами
// Разница между максимальным и минимальным элементами массива

//Для метода FindMax(double[] array): который 
//принимает на вход массив вещественных чисел array 
//и возвращает максимальное число из массива.

// if (array == null || array.Length == 0)
//     {
//         throw new ArgumentException("Массив не может быть пустым.");
//     }

//     double max = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }

//     return max;

//Для метода FindMin(double[] array): который 
//принимает на вход массив вещественных чисел array 
//и возвращает минимальное число из массива.

//  if (array == null || array.Length == 0)
//     {
//         throw new ArgumentException("Массив не может быть пустым.");
//     }

//     double min = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }

//     return min;

// Для метода CalcDifferenceBetweenMaxMin(double[] array): принимает на вход
// массив вещественных чисел array 
// и возвращает разницу между максимальным и минимальным числами в массиве.

// if (array == null || array.Length == 0)
//     {
//         throw new ArgumentException("Массив не может быть пустым.");
//     }

//     double min = array[0];
//     double max = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }

//     double difference = max - min;

//     return difference;


// Для метода PrintArray(double[] array): Метод для вывода массива на экран. 
//Он принимает на вход массив array и выводит его элементы
// с двумя знаками после запятой через табуляцию.

// if (array == null || array.Length == 0)
//     {
//         Console.WriteLine("Массив пустой.");
//         return;
//     }

//     foreach (double number in array)
//     {
//         Console.Write($"{number:F2}\t"); // Вывод элемента с двумя знаками после запятой через табуляцию
//     }

//     Console.WriteLine(); // Переход на новую строку после вывода всех элементов