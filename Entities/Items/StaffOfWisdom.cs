public class StaffOfWisdom : Item
{
    public const int Damage = 50;
    public const int SpellPower = 80;
    public const int Mana = 100;
    public const int Income = 0;
    public const int ItemPrice = 800;

    public StaffOfWisdom(string name) : base(name, Damage, SpellPower, Mana, Income, ItemPrice)
    {
    }
}