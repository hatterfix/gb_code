// Код переворачивает массив, меняя элементы местами
// [1,2,3,4 ==> 4,3,2,1]

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


//Функция меняет элементы массивв местами
void reverseArray(int[] array)
{
    int temp = 0 ;
    // за одну итерацию идет сразу 2 присваивания с начала массива и с конца, поэтому необходимо пройти половину массива
    for (int i = 0 ; i < array.Length / 2; i++) 
    {
        temp = array[i] ; //например, массив из 10 элементов, начинаем с нулевого элемента array[0], тут temp = 0 ;
        array[i] = array[array.Length - 1 - i] ; // перезаписываем в array[0] 10 - 1 - 0 = значение из array[9]
        array[array.Length - 1 - i] = temp ; // на втором шаге перезаписываем в array[9] значеение temp , т е элемент array[0]
    }
}
//--------------------------------------------------------------------------------------------------------------------

int[] myArray = generateArray(10 , 0 ,9) ;
arrayPrint(myArray);
reverseArray(myArray);
System.Console.WriteLine("");
arrayPrint(myArray);
