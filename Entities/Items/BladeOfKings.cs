public class BladeOfKings : Item
{
    public const int Damage = 300;
    public const int SpellPower = 20;
    public const int Mana = 20;
    public const int Income = 500;
    public const int ItemPrice = 2500;

    public BladeOfKings(string name) : base(name, Damage, SpellPower, Mana, Income, ItemPrice)
    {
    }
}