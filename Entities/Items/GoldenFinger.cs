public class GoldenFinger : Item
{
    public const int Damage = 0;
    public const int SpellPower = 0;
    public const int Mana = 0;
    public const int Income = 1000;
    public const int ItemPrice = 2000;

    public GoldenFinger(string name) : base(name, Damage, SpellPower, Mana, Income, ItemPrice)
    {
    }
}