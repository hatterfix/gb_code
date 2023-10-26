// Код задает массив из 12 элементов [-9 ... 9 ]
//тзкт сумму положительныз и отрицательных элементов

// Фкнкция обработки массива, оперирует переменными:
// Ращмерность массива , первый элемент, последний элемент


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
        for (int i = 0 ; i < arrayForPrint.Length ; i++)
        {
            System.Console.Write(arrayForPrint[i] + " ");
        }
    }
//-----------------------------------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

int sumPositive = 0 ;
int sumNegative = 0 ;

for (int i = 0 ; i < array.Length ; i++)
    {
       if (array[i] > 0)
       {
        sumPositive += array[i] ;
       }
       else 
       sumNegative += array[i] ;
    }

System.Console.WriteLine($"\nСумма положительных: {sumPositive}") ;
System.Console.WriteLine($"\nСумма отрицательных: {sumNegative}") ;