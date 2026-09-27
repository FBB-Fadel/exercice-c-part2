public class NotificationConsole : INotification
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"CONSOLE : {message}");
    }
}