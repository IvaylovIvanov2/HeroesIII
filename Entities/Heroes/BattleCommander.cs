public class BattleCommander : Hero
{
    public const int StartingMana = 100;
    public const int StartingSpellPower = 20;
    public const int StartingGold = 10000;
    public const int StartingIncome = 500;

    public BattleCommander(string name) : base(name, StartingMana, StartingSpellPower, StartingGold, StartingIncome)
    {
    }

    public override int ArmyDamage
    {
        get
        {
            return base.ArmyDamage + (base.ArmyDamage * 20 / 100);
        }
    }
}
