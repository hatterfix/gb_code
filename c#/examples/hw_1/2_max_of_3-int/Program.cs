// Код, который принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите первое целое число: ") ;
int a = Convert.ToInt32(Console.ReadLine()) ;
Console.Write ("Введите второе целое число: ") ;
int b = Convert.ToInt32(Console.ReadLine()) ;
Console.Write ("Введите тоетье целое число: ") ;
int c = Convert.ToInt32(Console.ReadLine()) ;

int result = a;

if(b > result)
{
result = b ;
}
if(c > result)
{
result = c ;
}
    Console.WriteLine($"Наибольшее число `{result}`") ;

// Код для автотеста , который по условию должен содержать return result;
// int result = a;

// if(b > result)
// {
//     result = b;
// }
// if(c > result)
// {
//     result = c;
// }
// return result;
