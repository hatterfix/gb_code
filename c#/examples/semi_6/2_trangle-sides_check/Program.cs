//Код принимает на вход 3 числа и проверяет
//может ли существовать треугольник 
//со сторонами такой длины

//По теореме о неравенстве треугольников
// Каждая сторона меньше суммы двух сторон
        Console.Write("Введите значение стороны A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение стороны B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение стороны C: ");
        int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
    {
Console.WriteLine($"Треугольник со сторонами длиной: A = {a}, B = {b}, C = {c} может существовать.");
    }
    else 
    {
        Console.WriteLine($"Треугольник со сторонами длиной: A = {a}, B = {b}, C = {c}  существовать не может.");
    }