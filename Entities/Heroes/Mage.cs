public class Mage : Hero
{
    public const int StartingMana = 200;
    public const int StartingSpellPower = 40;
    public const int StartingGold = 10000;
    public const int StartingIncome = 500;

    public Mage(string name) : base(name, StartingMana, StartingSpellPower, StartingGold, StartingIncome)
    {
    }
}
 
