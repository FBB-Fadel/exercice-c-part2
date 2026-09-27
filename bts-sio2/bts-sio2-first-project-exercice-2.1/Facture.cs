public class Facture : Document, IImpriable
{
    public decimal Montant { get; set; }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture : {Titre}");
        Console.WriteLine($"Montant : {Montant:F2} €");
    }
}