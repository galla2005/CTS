using System;

public sealed class Logger
{
    // Private static instance
    private static Logger instance = null;

    // Lock object for thread safety
    private static readonly object lockObject = new object();

    // Private constructor
    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    // Public method to get the single instance
    public static Logger GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    // Logging method
    public void Log(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
}