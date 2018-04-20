using System;

public class Item : IItem
{
    private string name;
    private int damageBonus;
    private int spellPowerBonus;
    private int goldPerRoundBonus;
    private int manaBonus;
    private int price;

    public Item(string name, int damageBonus, int spellPowerBonus, int manaBonus, int incomeBonus, int price)
    {
        this.Name = name;
        this.DamageBonus = damageBonus;
        this.SpellPowerBonus = spellPowerBonus;
        this.ManaBonus = manaBonus;
        this.IncomeBonus = incomeBonus;
        this.Price = price;
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public int DamageBonus
    {
        get { return this.damageBonus; }
        private set { this.damageBonus = value;}
    }

    public int SpellPowerBonus
    {
        get { return this.spellPowerBonus; }
        private set { this.spellPowerBonus = value; }
    }

    public int ManaBonus
    {
        get { return this.manaBonus; }
        private set { this.manaBonus = value; }
    }

    public int IncomeBonus
    {
        get { return this.goldPerRoundBonus; }
        private set { this.goldPerRoundBonus = value; }
    }

    public int Price
    {
        get { return this.price; }
        private set { this.price = value; }
    }

    
}
