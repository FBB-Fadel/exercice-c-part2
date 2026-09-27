

void AfficherElement(IAffichable element)
{
    element.Afficher();
}

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");
var commande = new Commande("CMD001", 129.90m);
var facture = new Facture("FAC001", 150.50m);

IImpriable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();

exportable.Exporter("facture.pdf");


List<IAffichable> elements = new();

elements.Add(produit);
elements.Add(client);
elements.Add(commande);

foreach (var element in elements)
{
    element.Afficher();
}


AfficherElement(produit);
AfficherElement(client);