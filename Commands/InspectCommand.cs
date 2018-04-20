using System;

public class InspectCommand : Command
{
    public InspectCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.InspectHero(this.Args);
    }
}
