void EnvoyerNotification(INotification notification, string message)
{
    notification.Envoyer(message);
}

var email = new NotificationEmail();
var sms = new NotificationSms();
var console = new NotificationConsole();

EnvoyerNotification(email, "Votre commande est prête.");
EnvoyerNotification(sms, "Votre commande est prête.");
EnvoyerNotification(console, "Votre commande est prête.");