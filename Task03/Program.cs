Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int ProductOfNumbers(int number)
{
    int amount;
    int product = 1;
    for (amount = 1; amount <= number; amount++)
    {
        product = product * amount;
    }
    return product;
}

int number = DataEntry("Введите число ");
int product = ProductOfNumbers(number);
Console.WriteLine($"Произведение всех числел до {number} -> {product}");