public class Trader : Hero
{
    public const int StartingMana = 100;
    public const int StartingSpellPower = 15;
    public const int StartingGold = 12000;
    public const int StartingIncome = 1000;

    public Trader(string name) : base(name, StartingMana, StartingSpellPower, StartingGold, StartingIncome)
    {
    }
}
