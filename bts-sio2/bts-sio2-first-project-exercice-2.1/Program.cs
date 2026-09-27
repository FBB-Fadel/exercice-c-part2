void AfficherElement(IAffichable element)
{
    element.Afficher();
}

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");

AfficherElement(produit);
AfficherElement(client);