using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hero : IHero
{
    public const int MaxIncome = 8000;
    public const int IncomeUpgradeCost = 1500;

    private string name;
    private int mana;
    private int spellPower;
    private int gold;
    private int income;
    private Dictionary<string, List<IUnit>> army;
    private List<IItem> items;

    public Hero(string name, int mana, int spellPower, int gold, int income)
    {
        this.Name = name;
        this.Mana = mana;
        this.SpellPower = spellPower;
        this.Gold = gold;
        this.Income = income;
        this.army = new Dictionary<string, List<IUnit>>();
        this.items = new List<IItem>();
    }

    public Dictionary<string, List<IUnit>> Army
    {
        get { return this.army; }
    }

    public int Income
    {
        get { return this.income + this.items.Sum(i => i.IncomeBonus); }
        protected set { this.income = value; }
    }

    public int Mana
    {
        get { return this.mana + this.items.Sum(i => i.ManaBonus); }
        protected set { this.mana = value; }
    }

    public int SpellPower
    {
        get { return this.spellPower + this.items.Sum(i => i.SpellPowerBonus); }
        protected set { this.spellPower = value; }
    }

    public int Gold
    {
        get { return this.gold; }
        protected set { this.gold = value; }
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public virtual int ArmyDamage
    {
        get
        {
            int armyDamage = 0;
            this.army.Values.ToList().ForEach(a => armyDamage += a.Sum(u => u.Damage));
            this.items.ForEach(i => armyDamage += i.DamageBonus);
            return armyDamage;
        }
    }

    public virtual int ArmyHealth
    {
        get
        {
            int armyHealth = 0;
            this.army.Values.ToList().ForEach(a => armyHealth += a.Sum(u => u.Damage));
            return armyHealth;
        }
    }

    public virtual int ArmyDefense
    {
        get
        {
            int defense = 0;
            this.army.Values.ToList().ForEach(a => defense += a.Sum(u => u.Defense));
            return defense;
        }
    }

    public virtual string HireUnits(IUnit unit, int unitsCount)
    {
        int totalCost = unit.Price * unitsCount;
        if(this.Gold < totalCost)
        {
            throw new Exception("These units need more gold!");
        }

        if (!this.army.ContainsKey(unit.Name))
        {
            this.army[unit.Name] = new List<IUnit>();
        }
        for(int i = 0; i < unitsCount; i++)
        this.army[unit.Name].Add(unit);

        this.Gold -= totalCost;
        return $"{this.Name} has hired {unitsCount} {unit.Name}!";
    }

    public string EquipItem(IItem item)
    {
        if(this.Gold < item.Price)
        {
            throw new Exception("Insufficient funds!");
        }

        if(this.items.Contains(item))
        {
            throw new Exception($"{this.Name} already has {item.Name}!");
        }

        this.items.Add(item);
        this.Gold -= item.Price;
        return $"{this.Name} purchased {item.Name}";
    }

    public string Upgrade()
    {
        if(this.Gold < IncomeUpgradeCost)
        {
            throw new Exception($"Not enough gold to upgrade the income of {this.Name}");
        }

        if(this.Income == MaxIncome)
        {
            throw new Exception($"Income for {this.Name} is upgraded entirely!");
        }

        this.Income *= 2;
        this.Gold -= IncomeUpgradeCost;
        if(this.Income > MaxIncome)
        {
            this.Income = MaxIncome;
        }
        return $"{this.Name} successfully upgraded their income.";
    }

    public virtual string SlayEnemy(IHero enemy)
    {
        return $"{this.Name} has slain {enemy.Name} the {enemy.GetType().Name}!";
    }

    public void GainIncome()
    {
        this.Gold += this.Income;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name} {this.Name}");
        sb.AppendLine($"Mana: {this.Mana}, SpellPower: {this.SpellPower}");
        sb.AppendLine($"Gold: {this.Gold}, Income: {this.Income}");
        sb.AppendLine($"Items: {string.Join(", ", this.items.Select(i => i.Name))}");
        sb.AppendLine($"Army strength: {this.ArmyDamage}");
        sb.AppendLine($"Army health: {this.ArmyHealth}");
        sb.AppendLine($"Army defense: {this.ArmyDefense}");
        sb.AppendLine($"Army units:");
        foreach(var unitType in this.army)
        {
            sb.AppendLine($"{unitType.Key}: {unitType.Value.Count}");
        }

        return sb.ToString().Trim();
    }
}
