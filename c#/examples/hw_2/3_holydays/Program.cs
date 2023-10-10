// Код который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным :
Console.Write ("Введите номер дня недели: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

if ( number >= 1 && number <= 5) 
{
    Console.WriteLine("Ой, Это будний день") ;
}
else if ( number == 6) 
{
    Console.WriteLine($"{number}-й день недели - суббота - выходной, ура !!!") ;
}
else if ( number == 7) 
{
    Console.WriteLine($"{number}-й день недели - воскоесенье - выходной, ура !!!") ;
}
else
{
    Console.WriteLine("Ой-ой... В неделе только 7 дней.") ;
}