// Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
// Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

DZ2();

void DZ2()
{
    string text = "Без труда не выловишь и рыбку из пруда";
    text = text.ToLower();
    char[] vowels = new char[10]{'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е'};
    int count = 0;
    int iText = 0;

    CountVowels(text, vowels, count, iText);
}

void CountVowels(string text, char[] vowels, int count, int iText)
{   
    
    if (iText < text.Length)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (text[iText] == vowels[j])
            {
                count++;
            }
        }
        iText++;
        CountVowels(text, vowels, count, iText);
    }
    else
    {
        Console.WriteLine($"Кол-во гласных: {count}");
    }    
}