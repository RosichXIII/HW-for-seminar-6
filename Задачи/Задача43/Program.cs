// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Z43();

void Z43()
{
        Console.WriteLine("Введите число b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число k2");
    int k2 = Convert.ToInt32(Console.ReadLine()); 

    CrossingPointCheck(b1, k1, b2, k2);

}

void CrossingPointCheck(int b1, int k1, int b2, int k2)
{
    double x;
    double y;
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (b2 - b1)/(k1 - k2);
        y = k2*x + b2;
        Console.WriteLine($"Точка пересечения прямых: {x}, {y}");
    }
}
