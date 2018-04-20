public class Program
{
    public static void Main()
    {
        IReader reader = new Reader();
        IWriter writer = new Writer();
        IUnitFactory unitFactory = new UnitFactory();
        IHeroFactory heroFactory = new HeroFactory();
        IItemFactory itemFactory = new ItemFactory();
        IGameController gameController = new GameController(unitFactory, heroFactory, itemFactory);
        ICommandInterpreter commandInterpreter = new CommandInterpreter(gameController);
        IEngine engine = new Engine(reader, writer, commandInterpreter);
        engine.Run();
    }
}
