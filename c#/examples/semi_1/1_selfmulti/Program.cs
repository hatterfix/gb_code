// Код получения квадрата числа (умножение само на себя)
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write ("Введите целое число: ") ;
// int number = Console.ReadLine() ; // нужно конвертировать string в int
// int.Parse() не обработает пустую строку || Convert.ToInt32() - обработает
int number = Convert.ToInt32(Console.ReadLine()) ;
int sqr = number * number ;
//Console.WriteLine($"Квадрат чесла равен {sqr}") ; 
// Запись в виде форматированной реременной
Console.WriteLine("Квадрат чесла равен " + sqr) ;