// Код , который принимает на вход координаты двух точек
// pointA и pointB в виде массива целых чисел,
// и возвращает расстояние между ними в 3D пространстве.
Console.Clear();
System.Console.WriteLine("Ведите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBx - userAx);
double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);//Math.Sqrt() находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2));//Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить)



// //Код , для Автотеста.
// double squareX = Math.Pow(pointB[0] - pointA[0], 2);
// double squareY = Math.Pow(pointB[1] - pointA[1], 2);
// double squareZ = Math.Pow(pointB[2] - pointA[2], 2);
// double result = Math.Sqrt(squareX + squareY + squareZ);
//       return result;