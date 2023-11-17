﻿//  Код вычисления функции Аккермана с помощью рекурсии.
// Учитывается, что в условии даны 2 неотрицательных числа M и N.


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

    int Acker(int M, int N)
    {
        if (M == 0)
            return N + 1;
        else if (N == 0)
            return Acker(M - 1, 1);
        else
            return Acker(M - 1, Acker(M, N - 1));
    }

    //------------------------------------------------------------------

        System.Console.Write("Введите значение M: ");
        int numM = ReadInt("Введите положительное число M: ");

        System.Console.Write("Введите значение N: ");
        int numN = ReadInt("Введите положительное число N: ");;

        int result = Acker(numM, numN);

        System.Console.WriteLine($"A({numM}, {numM}) = {result}");