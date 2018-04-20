using System;
using System.Linq;
using System.Reflection;

public class ItemFactory : IItemFactory
{
    public IItem CreateItem(string[] args)
    {
        Type itemType = (Type)Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(args[0]));

        if (itemType == null)
        {
            throw new Exception("There are no such items in the game!");
        }

        var data = new object[] { args[0] };

        return (IItem)Activator.CreateInstance(itemType, data);
    }
}
