using System;
using System.Collections.Generic;
using System.Linq;

public class GameController : IGameController
{
    private readonly IUnitFactory unitFactory;
    private readonly IHeroFactory heroFactory;
    private readonly IItemFactory itemFactory;
    private List<IHero> heroes;
    private int numberOfDay;

    public GameController(IUnitFactory unitFactory, IHeroFactory heroFactory, IItemFactory itemFactory)
    {
        this.unitFactory = unitFactory;
        this.heroFactory = heroFactory;
        this.itemFactory = itemFactory;
        this.heroes = new List<IHero>();
        this.numberOfDay = 1;
    }

    public string AddHero(string[] args)
    {
        if (this.heroes.Any(h => h.Name == args[0]))
        {
            throw new Exception($"Hero with the name \"{args[0]}\" has already been added!");
        }

        IHero hero = this.heroFactory.CreateHero(args);

        this.heroes.Add(hero);
        return $"{args[1]} {args[0]} has been added.";
    }

    public string HireUnit(string[] args)
    {
        IUnit unit = this.unitFactory.CreateUnit(args);
        var currentHero = this.heroes.FirstOrDefault(h => h.Name == args[2]);
        int unitsCount = int.Parse(args[0]);
        int totalCost = unitsCount * unit.Price;
        return currentHero.HireUnits(unit, unitsCount);
    }

    public string BuyItem(string[] args)
    {
        IItem item = this.itemFactory.CreateItem(args);
        IHero currentHero = this.heroes.FirstOrDefault(h => h.Name == args[1]);
        return currentHero.EquipItem(item);
    }

    public string AttackHero(string[] args)
    {
        var attackingHero = this.heroes.FirstOrDefault(h => h.Name == args[0]);
        var defendingHero = this.heroes.FirstOrDefault(h => h.Name == args[1]);

        int attackingHeroTotalPower = (attackingHero.ArmyDamage * 2) + attackingHero.ArmyHealth + attackingHero.ArmyDefense;
        int defendingHeroTotalPower = (defendingHero.ArmyDamage * 2) + defendingHero.ArmyHealth + attackingHero.ArmyDefense + (attackingHero.ArmyDefense * 50 / 100);
        string result = string.Empty;

        if (attackingHeroTotalPower > defendingHeroTotalPower)
        {
            result = attackingHero.SlayEnemy(defendingHero);
            defendingHero = null;
        }
        else
        {
            result = defendingHero.SlayEnemy(attackingHero);
            attackingHero = null;
        }
        return result;
    }

    public string UpgradeIncome(string[] args)
    {
        var currentHero = this.heroes.FirstOrDefault(h => h.Name == args[0]);
        if (currentHero == null)
        {
            throw new Exception("No such hero exists");
        }
        return currentHero.Upgrade();
    }

    public string InspectHero(string[] args)
    {
        var currentHero = this.heroes.FirstOrDefault(h => h.Name == args[0]);
        return currentHero.ToString();
    }

    public string Day()
    {
        foreach (var hero in this.heroes)
        {
            hero.GainIncome();
        }

        return $"Day {this.numberOfDay++} has passed! All heroes have gained gold according to their income.";
    }
}
