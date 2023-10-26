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
// Функция вывода массива через метод Join
// void intArrayJoin(int[] arrayForPrint)
//         {

//             System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
//         }

void sumOfNegativeAndPositive(int[] array, out int sumPositive, out int sumNegative)
{    
     // Вариант реализации функции, с модификатором out внутри:
    
    // Значения модификаторов должны быть явно объявлены
    sumPositive = 0 ;
    sumNegative = 0 ;

for (int i = 0 ; i < array.Length ; i++)
    {
       if (array[i] > 0)
       {
        sumPositive += array[i] ;
       }
       else 
       sumNegative += array[i] ;
    }
}
//-----------------------------------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

    // Вариант реализации функции, с модификатором out внутри:
// т.к. функция типа void, присваивать ее ничему не торбуется
// Однако, обязательно нужно объявить внутри модификаторы для обраюотки
 sumOfNegativeAndPositive(array, out int sumP, out int sumN);


System.Console.WriteLine($"\nСумма положительных: {sumP}") ;
System.Console.WriteLine($"\nСумма отрицательных: {sumN}") ;