public class Facture : IImpriable, IExportable
{
    public string Numero {get; set; }
    public decimal Montant{get; set; }

    public Facture(string numero,decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture {Numero}");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Export de la facture {Numero} vers {fichier}");
    }
}