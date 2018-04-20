public class Knight : Unit
{
    public const int InitialDamage = 25;
    public const int InitialHealth = 150;
    public const int InitialDefense = 8;
    public const int UnitPrice = 250;

    public Knight(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}
