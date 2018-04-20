using System.Collections.Generic;

public class Thief : Hero
{
    public const int StartingMana = 100;
    public const int StartingSpellPower = 20;
    public const int StartingGold = 7000;
    public const int StartingIncome = 500;

    public Thief(string name) : base(name, StartingMana, StartingSpellPower, StartingGold, StartingIncome)
    {
    }

    public override string SlayEnemy(IHero enemy)
    {
        foreach (var unitType in enemy.Army)
        {
            foreach (var unit in unitType.Value)
            {
                if (!this.Army.ContainsKey(unit.Name))
                {
                    this.Army[unit.Name] = new List<IUnit>();
                }
                this.Army[unit.Name].Add(unit);
            }
        }

        return $"{this.Name} the thief has slayn {enemy.GetType().Name} {enemy.Name} and has taken over his army!";
    }
}
