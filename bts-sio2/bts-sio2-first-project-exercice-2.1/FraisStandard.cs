public class FraisStandard : ICalculFrais
{
    public decimal Calculer(decimal montant)
    {
        return montant * 0.01m;
    }
}