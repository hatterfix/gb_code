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

int[] sumOfNegativeAndPositive(int[] array)
{    
    // Вариант реализации функции, с использованием массива:
int[] sumNumbers = new int[2] ;

for (int i = 0 ; i < array.Length ; i++)
    {
       if (array[i] > 0)
       {
        sumNumbers[0] += array[i] ;
       }
       else 
       sumNumbers[1] += array[i] ;
    }
    return sumNumbers ;
}
//-----------------------------------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

    // Вариант реализации функции, с использованием массива:
int[] result = sumOfNegativeAndPositive(array);


System.Console.WriteLine($"\nСумма положительных: {result[0]}") ;
System.Console.WriteLine($"\nСумма отрицательных: {result[1]}") ;