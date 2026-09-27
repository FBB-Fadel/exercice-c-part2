public class Client : IAffichable
{
    public string Nom { get; set; }
    public string Email { get; set; }

    public Client(string nom, string email)
    {
        Nom = nom;
        Email = email;
    }

    public void Afficher()
    {
        Console.WriteLine($"{Nom} - {Email}");
    }
}