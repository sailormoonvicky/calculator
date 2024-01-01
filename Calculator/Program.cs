// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("===============");

Console.Write("Please enter the operator: ");
string firstOperator = Console.ReadLine();

Console.Write("Please enter the first number: ");
string firstNumber = Console.ReadLine();
int x = int.Parse(firstNumber);

Console.Write("Please enter the second number: ");
string secondNumber = Console.ReadLine();
int y = int.Parse(secondNumber);

int answer = 0;

if (firstOperator == "+")
    answer = x + y;
else if (firstOperator == "-")
    answer = x - y;
else if (firstOperator == "*")
    answer = x * y;
else if (firstOperator == "/")
    answer = x / y;
else 
    Console.WriteLine("Sorry, I can't understand your operator, please enter the right one");

Console.WriteLine("The answer is: {0} ", answer);
Console.ReadLine();