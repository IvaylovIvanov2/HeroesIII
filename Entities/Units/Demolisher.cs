public class Demolisher : Unit
{
    public const int InitialDamage = 40;
    public const int InitialHealth = 10;
    public const int InitialDefense = 0;
    public const int UnitPrice = 80;

    public Demolisher(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}