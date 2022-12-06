Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine()!;
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);
int parsedInput2 = int.Parse(input2);

if (parsedInput1 > parsedInput2) 
{
    Console.WriteLine($"Первое число больше: {parsedInput1}");
}
else 
{
    Console.WriteLine($"Второе число больше: {parsedInput2}");
}