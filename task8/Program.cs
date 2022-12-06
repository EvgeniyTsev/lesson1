int i = 1;
Console.WriteLine("Введите число:");
string input = Console.ReadLine()!;
int parsedInput1 = int.Parse(input);
Console.WriteLine("Чётные числа от 1 до " + parsedInput1);
while (i <= parsedInput1)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}
