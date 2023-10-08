// Вводим 2 числа и провкряем, являктся ли первое число квалратом второго:
//  number1 = 25 , number2 = 5 --> да ;
//  number1 =  2 , number2 = 10 --> нет ;

Console.Write ("Введите первое целое число: ") ;
int number1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write ("Введите второе целое число: ") ;
int number2 = Convert.ToInt32(Console.ReadLine()) ;

if ( number1 == number2 * number2) 
{
    Console.WriteLine($"Верно!! Квадрат числа {number2}  равен {number1}") ;
}
else 
{
    Console.WriteLine($"Нет-нет-нет!! Квадрат числа {number2} это не {number1}") ;
}
