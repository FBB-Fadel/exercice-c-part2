public class FraisPremium : ICalculFrais
{
    public decimal Calculer(decimal montant)
    {
        return montant * 0.005m;
    }
}