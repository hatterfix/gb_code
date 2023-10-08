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
</details>

