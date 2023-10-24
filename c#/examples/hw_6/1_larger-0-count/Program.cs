// Код, который  считает сколько чисел больше 0 в массиве ввёл пользователь.
int[] CreateArray()
       {
        int[] numbers = new int[8]; // Создаем массив из 8 элементов

        // Заполняем массив введеггыми числами
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите число для элемента {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        return numbers;
    }
//Функция CountArray обрабатывает массив numbers и ищкт элементы > 0
int CountArray(int[] numbers)
{
int count = 0;
for(int i = 0; i < numbers.Length; i++)
    {
    if(numbers[i] > 0) count++;
    }
    return count;
    }
//---------------------------------------------------------

        int[] numbers = CreateArray(); // Вызов функции для создания массива
        int nonzero = CountArray(numbers) ;

        // Выводим массив с табуляцией , через запятую
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i] + "," + "\t"}");
        }
       // Выводим количество элкментов массива > 0
        Console.WriteLine($"Количество элементов массива больше ноля = {nonzero}");
        