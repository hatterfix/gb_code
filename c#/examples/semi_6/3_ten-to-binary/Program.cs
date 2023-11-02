// Код, который будет преобразовывать десятичное число в двоичное.

// 3 -> 11

// 2 -> 10

int ReadInt(string text)

{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void ShowBinary(int num) //Рекурсивная функция - вызывает саму себя
{
    if(num == 0) return; //  обязательное условие для остановки вызова функции (далее функция будет вызвана 7 раз)
    ShowBinary (num / 2); // вызов самой функции, на каждоим шаге делим значение на 2 для его уменьшения
    System.Console.Write(num%2); // действие - вывод на экран остатка от деления на 2 - от конечного значения вызова функции к начальному
}

//-----------------------------------------------------

int number = ReadInt("Введите число: ");
ShowBinary (number);
System.Console.WriteLine();
Console.WriteLine(Convert.ToString(number ,16)); // вывод значения в шестнадцатиричной системе
