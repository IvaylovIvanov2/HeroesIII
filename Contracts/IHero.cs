using System.Collections.Generic;

public interface IHero
{
    string Name { get; }
    int Mana { get; }
    int SpellPower { get; }
    int Gold { get; }
    Dictionary<string, List<IUnit>> Army { get; }

    int ArmyDamage { get; }
    int ArmyDefense { get; }
    int ArmyHealth { get; }

    string HireUnits(IUnit unit, int count);
    string EquipItem(IItem item);
    string Upgrade();
    string SlayEnemy(IHero enemy);
    void GainIncome();
}
