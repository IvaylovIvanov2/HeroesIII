using System;

public class BuyItemCommand : Command
{
    public BuyItemCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.BuyItem(this.Args);
    }
}
