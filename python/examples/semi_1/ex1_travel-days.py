# Задача 1
# Ищем за сколько дней машииа проедет указанное общее расстояние( без циклов)
n = int(input("Сколько за день проезжает машина? - "))
m = int(input("Общее расстояние: "))
# 750 : 700 = 1(ост. 50) + 1
# 2100 : 700 = 3 (ост. 0) + 0
print((m + n - 1) //  n)
# (m + n - 1) // n
# (1401 + 700 - 1) // 700 = 3
# print(-12 % 5) # 15 - 12 = 3
# print(-14 % 6) # 18 - 14
# print(-7 % 3) # 9 - 7