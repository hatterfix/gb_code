//Код выводит числа Фибоначи без использования рекурсии

int ReadInt(string text)
{ 
    Console.WriteLine("Введите число:"); 
    return Convert.ToInt32(Console.ReadLine());
}

void Fib(int N)
{
Console.Write("0 1 ");
int num1 = 0;
int num2 = 1;

for (int i = 0; i < N - 2; i++)
    {
    int res = num1 + num2; Console.Write(res + " ");
    num1 = num2; num2 = res;
    }
}

Fib(ReadInt(" "));
