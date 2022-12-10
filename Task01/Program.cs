// double i = 3.45666;
// i = Math.Round(i, 2);
// Console.WriteLine(i);

Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

int Sum(int number)
{
    int i;
    int sum = 0;
    for (i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int answer = Sum(number);
Console.WriteLine(answer);