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
//Добавляем поиск еоличества элементов через модификатор:
bool FindElement(int[] array, int element, out int count)
{
    count=0 ;
for (int i = 0 ; i < array.Length ; i++)
    if (array[i] == element) count++; // Сокращам синтаксис записи цикла
if (count !=0) return true ;
return false ;
}   


 //------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

int number = ReadInt("Введите искомое чтсло: ");

// Делаем вывод по условию.
// Обрабатываем в ветвлении сразу функцию 
if (FindElement(array, number, out int count))
{
    System.Console.WriteLine($"Ура! Число {number} есть в массиве! Количество = {count}");
}
else
{
    System.Console.WriteLine($"Увы, числа {number} в массиве нет");
}