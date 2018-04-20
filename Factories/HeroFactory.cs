using System;
using System.Linq;
using System.Reflection;

public class HeroFactory : IHeroFactory
{
    public IHero CreateHero(string[] args)
    {
        Type heroType = (Type)Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(args[1]));

        if (heroType == null)
        {
            throw new Exception("Hero type is invalid!");
        }

        object[] data = new object[] { args[0] };

        return (IHero)Activator.CreateInstance(heroType, data);
    }
}
