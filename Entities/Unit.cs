using System;

public abstract class Unit : IUnit
{
    private string name;
    private int damage;
    private int health;
    private int defense;
    private int price;

    public Unit(string name, int damage, int health, int defense, int price)
    {
        this.Name = name;
        this.Damage = damage;
        this.Health = health;
        this.Defense = defense;
        this.Price = price;
    }

    public string Name
    {
       get { return this.name; }
       private set { this.name = value; }
    }

    public int Damage
    {
        get { return this.damage; }
        private set { this.damage = value; }
    }

    public int Health
    {
        get { return this.health; }
        private set { this.health = value; }
    }

    public int Defense
    {
        get { return this.defense; }
        private set { this.defense = value; }
    }

    public int Price
    {
        get { return this.price; }
        private set { this.price = value; }
    }
}
