using System;

public class UpgradeIncomeCommand : Command
{
    public UpgradeIncomeCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.UpgradeIncome(this.Args);
    }
}
