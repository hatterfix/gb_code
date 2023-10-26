//Код меняет положительные элементы массива на отрицательные
// и наоборот
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

void ChangeArray(int[] array)
{
        for (int i = 0 ; i < array.Length ; i++)
        {
            array[i] = -array[i];
        }
}
    //------------------

int[] array = generateArray(10 , -9 ,9) ;
intArrayPrint(array);

ChangeArray(array);
intArrayPrint(array);
