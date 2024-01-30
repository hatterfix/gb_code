import pandas as pd
import random

# Создаем исходный DataFrame
lst = ['robot'] * 4
lst += ['human'] * 4
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})

# Получаем из него значения
unique_values = data['whoAmI'].unique()

# Создаем пустогй DataFrame для заполнения one_hot 
one_hot = pd.DataFrame()

# Создайм столбцы  для one_hot 
for value in unique_values:
    one_hot[value] = (data['whoAmI'] == value).astype(int)

# Объединяем начальный DataFrame с one hot
data_one_hot = pd.concat([data, one_hot], axis=1)

# Вывод на экран:
print("Исходный столбец:")
print(data['whoAmI'])
print("\nПреобразованный столбец в one hot формате:")
print(data_one_hot)
