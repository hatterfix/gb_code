# gb_code
Geekbrains study examples

<details><summary><b>### C#</b></summary>

#### Примечание:

- Публичный [.gitignore](https://github.com/github/gitignore/blob/main/VisualStudio.gitignore) для vscode.

- Вспомогательный софт: [Microsoft .NET SDK 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

###  Установка в Ubuntu 22.04

```sh
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-6.0 aspnetcore-runtime-6.0
```

- Инициализировать dotnet-консоль (стартер-пак структуры) в папке с проектом:

```sh
dotnet new console
```

- Запустить проект в консоли:

```sh
dotnet run
```


###  Базовые команды:

- Вывод данных:
```sh 
Console.Write("something");
```

- Считать данные c записью в переменную - Метод ReadLine (по-умолчанию возвращает переменную типа string): 
```sh
Console.Write("something");
string username = Console.ReadLine();
```


- Объявить целочисленную переменную:

```sh
int intA = 7
```

- Объявить тип вещественного числа для переменной (например, для деления с остатком):

```
double intA = 20 ;
double intB = 3 ;
Console.Write(intA / intB);
```

- Случайные числа (возвращает целое число от min до max , или от min до max-1):

```sh
new Random().Next(min,max);

double intA = new Random().Next(1, 10) ;
double intB = new Random().Next(1, 10) ;
Console.Write(intA / intB);
```

- Автоеревод значения переменной в нижний регистр (например, если вводим АНя, вместо аня)

```sh
if(user.ToLower() == "аня")

```

- Очистить консоль перед каждым запуском:

```sh
Console.Clear() ;
```

- Добавить отступ от левого и от верхнего края:

```sh
Console.SetCursorPosition(x,y) ;

```

- Методы конвертирования типа значений в integer:


##### Не обработает пустую строку
```sh
 int.Parse()

```

##### Обработает пустую строку
```sh
Convert.ToInt32()

```


##### Пример конвертации типа переменной в ReadLine():
```sh
int number = Convert.ToInt32(Console.ReadLine()) ;

```
- Множественные условия в цикле (else if):

Конструкция:

```sh
if (... something ...)
(
... make this .... ;
)
else if (...1st  other some ... ) 
(
... make that ... ;
)
else if (... 2nd other some ... ) 
( 
... make that ... ;
)
else 
(
... make different ... ;
)

```

- Цикл for:

Конструкция:

```sh
for (int i = -N ; i <= N ; i++)
{
Console.WriteLine(i);
}
```

- Остаток от деления = символ % ( в примере ниже - остаток от деления на 10)

```sh
if ( 99 < number && number < 1000) 
{
    Console.WriteLine($"{number%10} - последняя цифра в числе {number}") ;
}
```

- Вывод с отступом в табуляцию "\t":

```sh
{
    Console.Write(i + "\t");

}

```
- Функция Math.Abs - возвращает абсолютное значение от числа 

```sh

int number = Math.Abs(Convert.ToInt32(...)

```

- Структура функции:

```sh

         _тип_данных_    _название_функции_  (_принимаемые параметры_)

	{
          _Тело функции
	}
```

```sh

//Функция берет заданное число, считает сумму от 1 до числа и выводит результат

int SumNumbers(int a)
{
	int sum = 0 ;
	
	for (int i =1; i <= a ; i++)
	{
	sum += i;
	}

	return sum ; //оператор перехода - принудительно завершает функцию и возвращает значение 
}
```
- Синтаксис переменных для обработки массивов включает квадратные скобки: int[]

```sh
int[] newArray = new int[sizeArray] ; // массив newArray обрабатывает  одну ячкйку памяти со значениями переменной sizeArray

```

- Пример функции ддя заполнения массива случайными числами 
```sh
// Определяет размерность массива, и диапазон значений,  начальный и конечный элементы для Random

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

// Вызов функции:

int[] array = generateArray(10 , -9 ,9) ;


```
- Оператор условного null-значения ( ? ) 

```sh
string? ...
// Позволяет, например, обработать в коде null-строку, не выводя ошибок
```

- Модификаторы:

Позволяют возвращать несколько значений из функции.
Могут вызываться сразу внутри функций.

Фактически передают значимый тип данных по ссылке:

```sh
void sumOfNegativeAndPositive(int[] array, out int sumPositive, out int sumNegative)

// Для обработки внутри функции, значения модификаторов должны быть явно объявлены:
    sumPositive = 0 ;
    sumNegative = 0 ;

// Вызов функции:

 sumOfNegativeAndPositive(array, out int sumP, out int sumN);


System.Console.WriteLine($"\nСумма положительных: {sumP}") ;
System.Console.WriteLine($"\nСумма отрицательных: {sumN}") ;
```
</details>

<details><summary><b>### Python</b></summary>

#### Примечание:

Python - язык с динамически определяемыми типами данных - сам их оопрелеляет при запуске кода -  это влияет на его скорость


Запуск кода а cli :

```sh
python3 tmp.py

```

Запуск кода а VSCode - Ctrl + F5 / Run & debug (gui) :


Переменные с объявленным и пустым (none) и строковым (" " ; ' ') значением:

```sh
n = 6
n = none
n = "somestring"
n = 'something'
```

- Интерполяция - получение сложной строки из нескольких простых:
  Конструкцтя f "{var1} - (var2) - ..."

Пример:
```sh
a = 6
b = 7.42
c = "somestring"

print (f"{a} - {b} - {c}")
```
Ввод данных (по-умолчанию тип string):

```sh
#a = input()
#a = input("Введите строку: ")
a = int(input("Введите число: "))
print(a)
```

Приведение типов данных:
```sh
c = 5.86
print(c)
#меняем тип переменной на int
n = int(c)
print(n)

#Подсветить типы двнных (type) в выводе:
print(type(c))
print(type(n))

```

Округление по числу знаков после запятой round(число, кол-во знаеов после ,)

```sh
a = 7.86672162
b = 5.42767261

print(round(a*b, 3))
```
- Условия if / then / else - управляющие конструкции.
- Сложные условия описываются логическими И - and / ИЛИ - or
- 
Пример:
```sh
username = input('Введите имя: ')

if username == 'Маша' or username == 'Mawa':
    print("Ура, это же МАША!")

elif username == 'Марина':
    print("Я так ждала Вас, Марина!")

elif username == 'Ильнар':
    print('Ильнар - топ)')

else:
    print('Привет, ', username)
```

Цикл while - выполняем до тех пор пока:

Пример:

```sh
n = 423
sum = 0

while n > 0:
    x=n % 10
    sum = sum + x
    n = n // 10
print("Сумма элементов числа = " , sum)

```

Прерывание цикла - break

Пример:
```sh
i = 6
while i < 5:
    if i == 3:
        break
    i = i + 1
else:
    print("Пожалуй")
    print('хватит )')

print(i)
```
</details>
