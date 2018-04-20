using System;

public class AddHeroCommand : Command
{
    public AddHeroCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.AddHero(this.Args);
    }
}
