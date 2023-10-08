// Код выдает название дня недели ро заданному номеру :
Console.Write ("Введите номер дня недели: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

if ( number == 1) 
{
    Console.WriteLine($"{number}-й день недели - понедельник") ;
}
else if ( number == 2) 
{
    Console.WriteLine($"{number}-й день недели - вторник") ;
}
else if ( number == 3) 
{
    Console.WriteLine($"{number}-й день недели - среда") ;
}
else if ( number == 4) 
{
    Console.WriteLine($"{number}-й день недели - четверг") ;
}
else if ( number == 5) 
{
    Console.WriteLine($"{number}-й день недели - пятница") ;
}
else if ( number == 6) 
{
    Console.WriteLine($"{number}-й день недели - суббота, ура !!!") ;
}
else if ( number == 7) 
{
    Console.WriteLine($"{number}-й день недели - воскоесенье, уоа !!!") ;
}
else
{
    Console.WriteLine("Ой-ой... В неделе только 7 дней.") ;
}