# Код определяет является ли год весокосным
year = int(input("Введите год: "))
print(year % 4 == 0 and year % 100 != 0 or year % 400 == 0)