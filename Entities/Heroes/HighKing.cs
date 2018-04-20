public class HighKing : Hero
{
    public const int StartingMana = 100;
    public const int StartingSpellPower = 20;
    public const int StartingGold = 10000;
    public const int StartingIncome = 500;

    public HighKing(string name) : base(name, StartingMana, StartingSpellPower, StartingGold, StartingIncome)
    {
    }

    public override string HireUnits(IUnit unit, int unitsCount)
    {
        base.HireUnits(unit, unitsCount);
        for (int i = 0; i < unitsCount / 10; i++)
        {
            this.Army[unit.Name].Add(unit);
        }

        return $"{this.GetType().Name} {this.Name} has hired {unitsCount} + {unitsCount / 10} {unit.Name}";
    }
}
