arr = [5, 8, 6, 4, 9, 2, 7, 3]  # урожайность черничных кустов

max_berries = 0  # переменная для хранения максимального количества ягод

# Проходим по каждому кусту черники
for i in range(len(arr)):
    berries = arr[i]  # текущее количество ягод на кусте

    # Проверяем, есть ли соседние кусты и собираем ягоды с них
    if i > 0:
        berries += arr[i-1]
    if i < len(arr)-1:
        berries += arr[i+1]

    # Обновляем максимальное количество ягод, если текущее количество больше
    if berries > max_berries:
        max_berries = berries

# Выводим максимальное количество ягод
print(max_berries)