// Код принимает на вход трёхзначное число и выводит вторую цифру в нём
Console.Write ("Введите трёхзначное число: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

if ( 99 < number && number < 1000) 
{
    Console.WriteLine($"{(number / 10)%10} - вторая цифра в числе {number}") ;
}
else 
{
    Console.WriteLine("Ошибка - Число не трёхзначное") ;
}