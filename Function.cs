using System;

// This is a custom print function that takes in a string and writes it to the console
class CustomPrintFunction
{
    public static void CustomCommand(string text)
    {
        Console.WriteLine(text);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // This is an example of how to use the custom print function
        CustomPrintFunction.CustomCommand("Text Here!");
    }
}
