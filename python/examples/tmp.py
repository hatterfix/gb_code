## tmp.py
n = int(input("Введите число: "))
flag = True
i = 2

while flag:
     # если остаток при делении числа п на 1 равен 0
    if n % i == 0:
        flag = False
        print(i)
# делитьель числа не может превышать введенное введенное число деленое на 2
    elif i > n // 2: 
        print(n)
        flag = False
    i += 1