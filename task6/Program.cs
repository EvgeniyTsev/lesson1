Console.WriteLine("Введите число:");
string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

if (parsedInput1 % 2 == 1)
{
    Console.WriteLine($"Число {parsedInput1} является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine($"Число {parsedInput1} является: ЧЁТНЫМ");
}
