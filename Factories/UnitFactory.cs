using System;
using System.Linq;
using System.Reflection;

public class UnitFactory : IUnitFactory
{
    public UnitFactory()
    {
    }

    public IUnit CreateUnit(string[] args)
    {
        Type unitType = (Type)Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(args[1]));

        if (unitType == null)
        {
            throw new Exception("Invalid type of unit!");
        }

        var data = new object[] { args[1] };

        return (IUnit)Activator.CreateInstance(unitType, data);
    }
}
