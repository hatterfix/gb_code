// Код считает произведение пар элементов масства
// Первый с последним, второй с предпоследним м т д
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

int[] multiArrayElements (int[] array)
{
    int[] newArray = new int[(array.Length + 1) / 2] ;
    for (int i = 0 ; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i] ;
    }

    if (array.Length % 2 == 1)
         newArray[newArray.Length - 1] = array[array.Length / 2] ;
    return newArray ;
}
//-----------

int[] array = generateArray(9 , 0 ,10) ;
intArrayPrint(array);

intArrayPrint(multiArrayElements(array));
