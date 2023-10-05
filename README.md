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

- Считать данные c записью в переменную типа string: 
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



</details>
