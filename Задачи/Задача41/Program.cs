// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Z41();

void Z41()
{
    Console.WriteLine("Задайте кол-во вводимых чисел");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
}

void FillArray(int[] array)
{    
        for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    int count = 0;
    Console.WriteLine("Массив");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        Console.Write(array[i] + "\t");
    }    
    Console.WriteLine("Кол-во положительных чисел: " + count);
}