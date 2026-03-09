// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Statistics Calculator - Main Version");
Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: No numbers provided.");
    return;
}

string[] dividedParts = input.Split(' ');

Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(dividedParts)}");
Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(dividedParts)}");
Console.WriteLine($"Min: {StatisticsHelper.CalculateMin(dividedParts)}");