// Задача 3. Дано число N. Используя только операцию деления и рекурсию, определите, что оно является степенью числа 3.

DZ3();

void DZ3()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int targetBase = 3;
    int divisible = number;

    PowThreeCheck(number, divisible, targetBase);
}

void PowThreeCheck(int number, int divisible, int targetBase)
{
    if (divisible >= targetBase)
    {
        if (divisible % targetBase == 0)
        {
            divisible /= targetBase;
            PowThreeCheck(number, divisible, targetBase);
        }
        else
        {
            Console.WriteLine($"Число {number} не является степенью числа {targetBase}");
        }
    }
    else if (divisible == 1)
    {
        Console.WriteLine($"Число {number} является степенью числа {targetBase}");
    }
    else
    {
        Console.WriteLine($"Число {number} не является степенью числа {targetBase}");
    }
}