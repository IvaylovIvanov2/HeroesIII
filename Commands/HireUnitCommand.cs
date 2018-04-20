using System;

public class HireUnitCommand : Command
{
    public HireUnitCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.HireUnit(this.Args);
    }
}
