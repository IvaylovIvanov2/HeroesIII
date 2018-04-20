public class Archangel : Unit
{
    public const int InitialDamage = 55;
    public const int InitialHealth = 250;
    public const int InitialDefense = 15;
    public const int UnitPrice = 450;

    public Archangel(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}