//  Код выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write ("Введите целое число: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

while ( number > 1000 ) 
{
    number = number / 10 ;
}

if ( 99 < number && number < 1000) 
{
    Console.WriteLine($"{number%10} - третья цифра в числе") ;
}
else 
{
    Console.WriteLine($"Ошибка - в числе {number} нет 3-й цифры.") ;
}

