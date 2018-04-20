public class GuardianOfKings : Unit
{
    public const int InitialDamage = 40;
    public const int InitialHealth = 200;
    public const int InitialDefense = 10;
    public const int UnitPrice = 350;

    public GuardianOfKings(string name) : base(name, InitialDamage, InitialHealth, InitialDefense, UnitPrice)
    {
    }
}
