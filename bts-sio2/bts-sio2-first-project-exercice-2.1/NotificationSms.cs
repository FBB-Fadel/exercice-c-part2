public class NotificationSms : INotification
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"SMS : {message}");
    }
}