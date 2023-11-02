// Код создаёт копию массива с помощью поэлементного копирования.

int[] generateArray (int sizeArray , int leftRange , int rightRange)
{
int[] tmpArray = new int[sizeArray] ;
Random rand = new Random() ;

// Цикл для заполнения массива случайными числами из указанного диапазона

for (int i = 0 ; i < tmpArray.Length ; i++)
    {
        tmpArray[i] = rand.Next(leftRange , rightRange + 1) ; // т к rand не обработает правое значение диапазона
    }
    return tmpArray ;
}


void arrayPrint(int[] array)
{
     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] Copy(int[] oldArray)
{
int[] newArray = new int[oldArray.Length];

for (int i = 0; i < oldArray.Length; i++) 
    newArray[i] = oldArray[i];

return newArray;
}

//--------------------------------------------------------------------------------------------------------------------

int[] myArray = generateArray(5, -5, 5);
int[] copyArray = Copy (myArray);
int[] secondArray = myArray;

myArray[0] = 100 ; // Для демонстрации, что функция копирования не обработает постусловия

arrayPrint(myArray); 
arrayPrint(copyArray); 
arrayPrint(secondArray); 