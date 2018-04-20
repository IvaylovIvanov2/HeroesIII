public class Swordsman : Unit
{
    public const int InitialDamage = 20;
    public const int InitialHealth = 100;
    public const int InitialDefense = 5;
    public const int UnitPrice = 170;

    public Swordsman(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}
