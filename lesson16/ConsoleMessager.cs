/// <summary>
/// Prints different kinds of messages in the console
/// </summary>
public class ConsoleMessager
{
    /// <summary>
    /// Prints a message with a certain color
    /// </summary>
    /// <param name="message">a message to print</param>
    /// <param name="color">message color</param>
    public static void WriteMessage(string message, ConsoleColor color)
    {
        var initialColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = initialColor;
    }

    /// <summary>
    /// Prints "Error: " + an error message in red
    /// </summary>
    /// <param name="error">error message to print</param>
    public static void WriteError(string error) => WriteMessage("Error: " + error, ConsoleColor.Red);
    
    /// <summary>
    /// Prints "Success: " + a success message in green
    /// </summary>
    /// <param name="message">success message to print</param>
    public static void WriteSuccess(string message) => WriteMessage("Success: " + message, ConsoleColor.Green);
}