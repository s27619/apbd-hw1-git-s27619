// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Calculator");
Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();
string[] dividedParts = input.Split(' ');

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: No numbers provided.");
    return;
}

Console.WriteLine("Statistics Calculator - Main Version");