//Задача 3: Задайте произвольный массив.
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите количество элементов массива: ");
int inputData = Convert.ToInt32(Console.ReadLine());
int[] myArr = FillArray(inputData);//Заполнили массив
Console.WriteLine("Массив, который заполнили: ");
PrintArray(myArr);

Console.WriteLine("Элементы массива, начиная с конца: ");
PrintArrayReversed(myArr, myArr.Length - 1);
Console.WriteLine("");

static void PrintArrayReversed(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReversed(array, index - 1);
    }
}
//===================================================
//МЕТОД ЗАПОЛНЕНИЯ МАССИВА
int[] FillArray(int numElements)
{
    int[] array = new int[numElements];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}
//===================================================
//МЕТОД ВЫВОДА МАССИВА НА ЭКРАН
void PrintArray(int[] array)
{
    int element;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        element = array[i];
        Console.Write(element + " ");
    }
    Console.WriteLine();
}