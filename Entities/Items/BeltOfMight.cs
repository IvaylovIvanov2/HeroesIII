public class BeltOfMight : Item
{
    public const int Damage = 150;
    public const int SpellPower = 0;
    public const int Mana = 0;
    public const int Income = 0;
    public const int ItemPrice = 150;

    public BeltOfMight(string name) : base(name, Damage, SpellPower, Mana, Income, ItemPrice)
    {
    }
}