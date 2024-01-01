// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("===============");

Console.Write("Please enter the operator: ");
string firstOperator = Console.ReadLine();

// Console.Write("Please enter the first number: ");
// string firstNumber = Console.ReadLine();
// int x = int.Parse(firstNumber);
//
// Console.Write("Please enter the second number: ");
// string secondNumber = Console.ReadLine();
// int y = int.Parse(secondNumber);
//
// int answer = 0;
//
// if (firstOperator == "+")
//     answer = x + y;
// else if (firstOperator == "-")
//     answer = x - y;
// else if (firstOperator == "*")
//     answer = x * y;
// else if (firstOperator == "/")
//     answer = x / y;
// else 
//     Console.WriteLine("Sorry, I can't understand your operator, please enter the right one");

Console.Write("How many numbers do you want to {0}?:",firstOperator);
int len = int.Parse(Console.ReadLine());

int[] numbers = new int[len];

for (int i = 0; i < len; i++)
{
    Console.Write("Please enter number {0}: ",i+1);
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(numbers);

int answer = numbers[0];

for (int i = 1; i < len; i++)
{
    if (firstOperator == "+")
        answer += numbers[i];
    else if (firstOperator == "-")
        answer -= numbers[i];
    else if (firstOperator == "*")
        answer *= numbers[i];
    else if (firstOperator == "/")
        answer /= numbers[i];
}

Console.WriteLine("The answer is: {0} ", answer);
Console.ReadLine();