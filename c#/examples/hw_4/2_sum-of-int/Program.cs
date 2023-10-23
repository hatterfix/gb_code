int ReadInt(string text)
{
    Console.Write (text) ;
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int SumOfDigits(int number)
    {
        int sum = 0;
        int remind;

        while (number > 0)
        {
            remind = number % 10;
            sum += remind;
            number /= 10;
        }

        return sum;
    }   
//---------------------------------------------------------

int number = ReadInt("Введите число: ") ;

int sum = SumOfDigits(number);

Console.WriteLine($"Скмма цифр в числе {number} = {sum}");
