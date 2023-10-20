// Код принимает на взод число и выводит количество цифр в нём

Console.Write ("Введите целое число: ") ;
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())) ;

// 1 способ - с использованием строк
string strNum = Convert.ToString(number) ;
Console.WriteLine ($"Количество символов в числе = {strNum.Length}") ;


//2 способ - деление на 10
int len = 0;

while (number > 0)
{
    number/=10 ;
    len++;
}
Console.WriteLine($"Количество символов в числе = {len}") ;