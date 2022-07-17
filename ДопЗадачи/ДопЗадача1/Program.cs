// Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.

DZ1();

void DZ1()
{
    Random random = new Random();
    int number = random.Next(0, 1001);
    Console.WriteLine("Число: " + number);
    int[] array = new int[(Convert.ToString(number, 2)).Length];
    int index = array.Length-1;

    ToBinary(number, array, index);
}

void ToBinary(int number, int[] array, int index)
{        
    if (number > 0)
    {
        array[index] = number%2;
        index--;
        number/=2;
        ToBinary(number, array, index);
    }
    else
    {
        Console.Write("Число в двоичной форме: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }         
    }
}