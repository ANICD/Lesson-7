//адача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System.Runtime.CompilerServices;

int randomNumber = new Random().Next(1, 10);
Console.WriteLine("Наше число: " + randomNumber);

//Рекупсивная функция. Т.к. по заданию М - это начальное число, то можно сразу задать его значение. Здесь М = 1

int number1 = 1;

Console.WriteLine("Печатаем ряд натуральных чисел от " + number1 + " до " + randomNumber);
PrintNaturalNumbers(number1, randomNumber);
Console.WriteLine();

//теперь рекурсивная функция.
void PrintNaturalNumbers(int num1, int num2)
{
    Console.Write(num1 + " ");
    if (num1 >= num2)
    {
        return;
    }
    PrintNaturalNumbers(num1 + 1, num2);
}
