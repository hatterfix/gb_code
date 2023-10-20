// Код принимает на взод число и выводит количество цифр в нём

//3 способ - применение функций:

int ReadInt(string text)
{
    Console.Write (text) ;
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int LenNumber(int value)
{
int len = 0;

    while (value > 0)
    {
    value/=10 ;
    len++;
    }
    return len;
}
//---------------------------------------------------------


int number = ReadInt("Введите число: ") ;

Console.WriteLine ($"Количество символов в числе = {LenNumber(number)}") ;



// // 1 способ - с использованием строк
// string strNum = Convert.ToString(number) ;
// Console.WriteLine ($"Количество символов в числе = {strNum.Length}") ;


// //2 способ - деление на 10
// int len = 0;

// while (number > 0)
// {
//     number/=10 ;
//     len++;
// }
// Console.WriteLine($"Количество символов в числе = {len}") ;