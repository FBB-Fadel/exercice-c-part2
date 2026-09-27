public class Commande : IAffichable
{
    public string Numero { get; set; }
    public decimal Montant { get; set; }

    public Commande(string numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Afficher()
    {
        Console.WriteLine($"Commande {Numero} - {Montant:F2} €");
    }
}