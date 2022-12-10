Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int AmountOfNumbers(int number)
{
    int amount = 0;
    for (amount = 0; number > 0; amount++)
    {
        number = number / 10;
    }
    return amount;
}

int number = DataEntryXY("Введите число ");
int amount = AmountOfNumbers(number);
Console.WriteLine($"В числе {number} -> {amount} числа");