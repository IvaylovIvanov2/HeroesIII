public class RingOfDestiny : Item
{
    public const int Damage = 100;
    public const int SpellPower = 100;
    public const int Mana = 100;
    public const int Income = 500;
    public const int ItemPrice = 1500;

    public RingOfDestiny(string name) : base(name, Damage, SpellPower, Mana, Income, ItemPrice)
    {
    }
}