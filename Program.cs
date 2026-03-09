// See https://aka.ms/new-console-template for more information

class Program 
{
    static void Main()
    {
        Console.WriteLine("Statistics Calculator - Main Version");
        Console.WriteLine("Enter numbers separated by space:");

        string? input = Console.ReadLine(); // nullable string
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: No numbers provided.");
            return;
        }

        // Split the input string and convert each part to int
        string[] dividedParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int[] numbers;
        try
        {
            numbers = Array.ConvertAll(dividedParts, int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter only valid integers.");
            return;
        }

        Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");
        Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers)}");
        Console.WriteLine($"Min: {StatisticsHelper.CalculateMin(numbers)}");
    }
}
