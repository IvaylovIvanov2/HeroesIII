using System;
using System.Linq;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    public const string CommandSuffix = "Command";

    private readonly IGameController gameController;

    public CommandInterpreter(IGameController gameController)
    {
        this.gameController = gameController;
    }

    public string InterpretCommand(string[] args)
    {
        Type commandType = (Type)Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.Equals(args[0] + CommandSuffix));

        if (commandType == null)
        {
            throw new Exception("Invalid command!");
        }

        var data = new object[] { args.Skip(1).ToArray(), gameController };

        ICommand command = (ICommand)Activator.CreateInstance(commandType, data);
        return command.Execute();
    }
}
