public class Pikeman : Unit
{
    public const int InitialDamage = 5;
    public const int InitialHealth = 30;
    public const int InitialDefense = 1;
    public const int UnitPrice = 50;

    public Pikeman(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}
