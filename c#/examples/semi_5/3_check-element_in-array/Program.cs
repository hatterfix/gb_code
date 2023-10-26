// Код ищет присутствует ли заданный элемент в массиве.
int[] generateArray (int sizeArray , int leftRange , int rightRange)
{
int[] newArray = new int[sizeArray] ;
Random rand = new Random() ;

// Цикл для заполнения массива случайными числами из указанного диапазона

for (int i = 0 ; i < newArray.Length ; i++)
    {
        newArray[i] = rand.Next(leftRange , rightRange + 1) ; // т к rand не обработает правое значение диапазона
    }
    return newArray ;
}


void intArrayPrint(int[] arrayForPrint)
        {

            System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
        }

int ReadInt(string text)
{
System.Console.Write(text) ;
return Convert.ToInt32(Console.ReadLine()) ;
}

bool FindElement(int[] array, int element)
{
for (int i = 0 ; i < array.Length ; i++)
    if (array[i] == element) return true; // Сокращам синтаксис записи цикла

    return false ;
}   


 //------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

int number = ReadInt("Введите искомое чтсло: ");

bool key = FindElement(array, number);

// Делаем вывод по условию.
// синтаксис if(key) , при типе bool, по-умолчанию true 
if(key)
{
    System.Console.WriteLine($"Ура! Число {number} есть в массиве!");
}
else
{
    System.Console.WriteLine($"Увы, числа {number} в массиве нет");
}