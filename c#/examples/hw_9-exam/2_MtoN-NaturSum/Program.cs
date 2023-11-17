// Код выводит сумму натуральных эоементов от M до N,
// С помощью функции SumNumbers()


int ReadInt(string text)
// модификатор result добавлен для исключения ошибки ввода чисел < 0
// Метод TryParse используется для его обработки по условиям ввода в цикле while
{
        int result;
        while (!int.TryParse(System.Console.ReadLine(), out result) || result <= 0)
        {
            System.Console.WriteLine("Ошибка ввода. Пожалуйста, введите натуральное число > 0.");
            System.Console.Write(text);
        }
        return result;
}

//Функция для поиска суммы элементов между M и N

int SumNumbers(int M, int N)
{
	int sum = 0 ;
	
	for (int i =M; i <= N; i++ )
	{
	sum += i;
	}

	return sum ;  
}
//---------------------------------------------------------

System.Console.WriteLine("Введите начальное число M:");
int numM = ReadInt("Введите натуральное число M: ");

Console.WriteLine ("Введите конечное число N: ") ;
int numN = ReadInt("Введите натуральное число N: ");

if (numM > numN)
        {
            Console.WriteLine($"Ошибка: начальное число M не может быть больше конечного числа N ");
            return;
        }

System.Console.WriteLine($"Сумма чисел от M до N равна {SumNumbers(numM,numN)}");