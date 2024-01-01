// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator!");

Console.Write("Input your first number: ");

int x = int.Parse(Console.ReadLine());


Console.Write("Input your second number: ");
int y = int.Parse(Console.ReadLine());

int z = x + y;

Console.WriteLine("Result: " + z);
Console.ReadLine();