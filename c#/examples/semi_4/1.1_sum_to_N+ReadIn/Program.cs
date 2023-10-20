// Код выводит сумму чисел от 1 до N,
// С помощью функции SumNumbers()

// Описываем функцию, 
//Берет заданное число, считает сумму от 1 до числа и возвращает результат

int SumNumbers(int a)
{
	int sum = 0 ;
	
	for (int i =1; i <= a ; i++)
	{
	sum += i;
	}

	return sum ; //оператор перехода - принудительно завершает функцию и возвращает значение 
}

int ReadInt(string text)
{
    Console.Write (text) ;
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
//---------------------------------------------------------


int number = ReadInt("Введите число N: ") ;

Console.WriteLine($"Сумма чисел от 1 до N = {SumNumbers(number)}"); //Выводим результат функции SumNumbers

Console.WriteLine($"---------------------------------------------");

Console.WriteLine($"Сумма чисел от 1 до N = {SumNumbers(5)}");

Console.WriteLine($"---------------------------------------------");

Console.WriteLine($"Сумма чисел от 1 до N = {SumNumbers(7)}");

Console.WriteLine($"---------------------------------------------");

Console.WriteLine($"Сумма чисел от 1 до N = {SumNumbers(9)}");