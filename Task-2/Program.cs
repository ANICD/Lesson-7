//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = funcAckermann(num1, num2);
Console.WriteLine("Значение функции Аккермана чисел " + num1 + " и " + num2 + " равно: " + result);

static int funcAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return funcAckermann(m - 1, 1);
    }
    else
    {
        return funcAckermann(m - 1, funcAckermann(m, n - 1));
    }
}
