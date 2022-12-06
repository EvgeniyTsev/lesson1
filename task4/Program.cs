Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine()!;
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine()!;
Console.WriteLine("Введите третье число");
string input3 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);
int parsedInput2 = int.Parse(input2);
int parsedInput3 = int.Parse(input3);

if (parsedInput1 > parsedInput2) 
{
    if (parsedInput1 > parsedInput3)
    {
        Console.WriteLine($"Максимальное число: {parsedInput1}");
    }
    else
    {
        Console.WriteLine($"Максимальное число: {parsedInput3}");
    }
}

else if (parsedInput2 > parsedInput3)
{
    Console.WriteLine($"Максимальное число: {parsedInput2}");
}
else
{
    Console.WriteLine($"Максимальное число: {parsedInput3}");
}