static class Validation
{
    public static decimal GetValidInputForNumber()
    {
        decimal choice;
        string? input = Console.ReadLine() ?? "";
        while (!decimal.TryParse(input, out choice))
        {
            Console.WriteLine("Invalid data entered. Please try again. ");
            Console.Write("Input: ");
            input = Console.ReadLine() ?? "";
        }

        return choice;
    }

    public static string GetValidInputForString()
    {
        string? input = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid data entered. Please try again. ");
            Console.Write("Input: ");
            input = Console.ReadLine() ?? "";
        }

        return input;
    }

}