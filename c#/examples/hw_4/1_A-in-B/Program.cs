//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


int ReadInt(string text)
{
    Console.Write (text) ;
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int Power(int A, int B)
    {
        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }
        return result;
    }   
//---------------------------------------------------------

int numA = ReadInt("Введите число A: ") ;

int numB = ReadInt("Введите число B: ") ;


int result = Power(numA, numB);

Console.WriteLine($"Результат {numA} в степени {numB}: {result}");

