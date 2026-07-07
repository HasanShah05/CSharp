using System;

public class Program
{
    static int GetInt(int[] array, int index)
    {
        try
        {
            return array[index];
        }
        catch (IndexOutOfRangeException e)
        {
            // Throwing a brand new, more specific error
            throw new ArgumentOutOfRangeException(
                "Parameter index is out of range.", e);
        }
    }

    public static void Main()
    {
        // FIX: Use commas to separate the items
        int[] numbers = [3, 4, 5]; 

        try
        {
            Console.WriteLine("Fetching number...");
            int result = GetInt(numbers, 5); 
            Console.WriteLine(result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // This catches the new exception you threw!
            Console.WriteLine($"Error Caught: {ex.Message}");
        }
    }
}