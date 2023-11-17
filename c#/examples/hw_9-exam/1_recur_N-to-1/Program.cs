// Код ыведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


//Функция для ввода числа N:

int ReadInt(string text)
// модификатор result добавлен для исключения ошибки ввода чисел < 0
// Метод TryParse используется для его обработки по условиям ввода в цикле while
{
        int result;
        while (!int.TryParse(System.Console.ReadLine(), out result) || result <= 0)
        {
            System.Console.WriteLine("Ошибка ввода. Пожалуйста, введите натуральное число > 0.");
            System.Console.Write(text);
        }
        return result;
}

void ShowNum(int num) //Рекурсивная функция - вызывает саму себя
{
    if(num == 0) return ; //  Условие для остановки вызова функции, доходим до 0
    System.Console.Write(num + ", "); // Выводим первое число
    ShowNum(num - 1);// Запускаем рекурсию, уменьшая число на 1
}

//-----------------------------------------------------

System.Console.WriteLine("Введите число N:");

int number = ReadInt("Введите натуральное число N: ");

ShowNum (number);
