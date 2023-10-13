// роверить является ли число пятизначным, 
// в противном случае - вывести 
// Число не пятизначное и False в следующей строке.
Console.Write ("Введите пятизначное число: ") ;

int number = Convert.ToInt32(Console.ReadLine()) ;
bool result = number >= 10000 && number <= 99999;

if ( number > 9999 && number < 100000) 
{
    Console.WriteLine($"{result}") ;
}
else 
{
    Console.WriteLine("Число не пятизначное") ;
    Console.WriteLine ($"{result}") ;
}


//Код для автотеста:
// bool result = number >= 10000 && number <= 99999;

// if ( number > 9999 && number < 100000) 
// {
//     return result;
// }
// else 
// {
//     Console.WriteLine("Число не пятизначное") ;
//     return result; 
// }