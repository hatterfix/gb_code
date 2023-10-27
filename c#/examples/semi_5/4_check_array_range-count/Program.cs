// Код ищет количество элементов массива в куазанном диапазоне
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

int CheckArray(int[] array)
{
  int count = 0;
  for (int i = 0 ; i < array.Length ; i++) 
  
  if (array[i] >= 10 && array[i] <= 99) count++ ;
  return count ;
}

//-----------------

int[] array = generateArray(20 , -100 ,100) ;
intArrayPrint(array);

int number = CheckArray(array);
System.Console.WriteLine($"\nКоличество искомых элементов в массиве {number} ");
