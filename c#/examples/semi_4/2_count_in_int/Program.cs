// Код принимает на взод число и выводит количество цифр в нём

Console.Write ("Введите целое число: ") ;
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())) ;

// 1 способ - с использованием строк
string strNum = Convert.ToString(number) ;
Console.WriteLine ($"Количкство символов в числе = {strNum.Length}") ;
