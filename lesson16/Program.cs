class Program
{
    static void Main(string[] args)
    {
        FileTimer.PrintWelcomeMessage();
        FileTimer.PrintOptions();

        var fileTimer = new FileTimer();
        
        while (true)
        {
            fileTimer.ReadLine();
        }    
    }
}