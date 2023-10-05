Console.Clear() ;
//Console.SetCursorPosition(4, 10) ;
//Console.WriteLine("+") ;

int xa = 20,  ya = 1, 
    xb = 1,   yb = 15,
    xc = 40,  yc = 30 ; 

Console.SetCursorPosition(xa, ya) ;
Console.WriteLine("+") ;

Console.SetCursorPosition(xb, yb) ;
Console.WriteLine("+") ;

Console.SetCursorPosition(xc, yc) ;
Console.WriteLine("+") ;


int x = xa, y = xb ;

int count = 0 ;

while(count < 1000)
{
    int wtf = new Random().Next(0, 3) ;
    if  (wtf == 0)
    {
        x = (x+xa)/2 ;
        y = (y+ya)/2 ;
    }
        if  (wtf == 1)
    {
        x = (x+xb)/2 ;
        y = (y+yb)/2 ;
    }
        if  (wtf == 2)
    {
        x = (x+xc)/2 ;
        y = (y+yc)/2 ;
    }

    Console.SetCursorPosition(x, y) ;
    Console.WriteLine("+") ;
    count++ ;
}   