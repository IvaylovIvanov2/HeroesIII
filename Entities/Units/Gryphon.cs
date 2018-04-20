public class Gryphon : Unit
{
    public const int InitialDamage = 20;
    public const int InitialHealth = 100;
    public const int InitialDefense = 0;
    public const int UnitPrice = 150;

    public Gryphon(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}