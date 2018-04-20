public class Archer : Unit
{
    public const int InitialDamage = 20;
    public const int InitialHealth = 20;
    public const int InitialDefense = 0;
    public const int UnitPrice = 60;

    public Archer(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}