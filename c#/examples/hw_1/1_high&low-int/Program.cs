// Код, который на вход принимает два числа
//  и выводит, какое число большее, а какое меньшее.
Console.Write ("Введите первое целое число: ") ;
int firstNumber = Convert.ToInt32(Console.ReadLine()) ;
Console.Write ("Введите второе целое число: ") ;
int secondNumber = Convert.ToInt32(Console.ReadLine()) ;

if ( firstNumber == secondNumber) 
{
    Console.WriteLine($"Введенные числа равны `{secondNumber}`") ;
}
if ( firstNumber > secondNumber) 
{
    Console.WriteLine($" Первое число `{firstNumber}`  больше чем второе число `{secondNumber}`") ;
}
if ( firstNumber < secondNumber) 
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`") ;
}
