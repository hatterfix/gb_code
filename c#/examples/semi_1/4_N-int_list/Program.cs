// Код принимает на вход целочисленное N и выводит список чисел от -N до N:

Console.Write ("Введите  целое число: ") ;
int N = Convert.ToInt32(Console.ReadLine()) ;

int M = N * -1 ; // Вводим доп переменную - обратного числа N
while (N != M)
{
Console.Write( "  " + M ) ;
M++ ;
}
