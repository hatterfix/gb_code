// Код выдает название дня недели ро заданному номеру :
Console.Write ("Введите номер дня недели: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;
if ( number < 1) 
{
    Console.WriteLine("Ой-Ой... Дни недели считаются с 1-го:") ;
}
if ( number == 1) 
{
    Console.WriteLine($"{number}-й день недели - понедельник") ;
}
if ( number == 2) 
{
    Console.WriteLine($"{number}-й день недели - вторник") ;
}
if ( number == 3) 
{
    Console.WriteLine($"{number}-й день недели - среда") ;
}
if ( number == 4) 
{
    Console.WriteLine($"{number}-й день недели - четверг") ;
}
if ( number == 5) 
{
    Console.WriteLine($"{number}-й день недели - пятница") ;
}
if ( number == 6) 
{
    Console.WriteLine($"{number}-й день недели - суббота, ура !!!") ;
}
if ( number == 7) 
{
    Console.WriteLine($"{number}-й день недели - воскоесенье, уоа !!!") ;
}
if ( number > 7) 
{
    Console.WriteLine("Ой-ой... В неделе только 7 дней.") ;
}