// Код, который задаёт массив из 8 элементов и выводит их на экран.

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
//---------------------------------------------------------

        int[] numbers = CreateArray(); // Вызов функции для создания массива

        // Выводим массив с табуляцией , через запятую
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i] + "," + "\t"}");
        }
        