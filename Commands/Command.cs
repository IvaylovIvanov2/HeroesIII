using System;

public abstract class Command : ICommand
{
    private string[] args;
    private IGameController gameController;

    public Command(string[] args, IGameController gameController)
    {
        this.args = args;
        this.gameController = gameController;
    }

    public IGameController GameController { get { return this.gameController; } }

    public string[] Args { get { return this.args; } }

    public abstract string Execute();
}
