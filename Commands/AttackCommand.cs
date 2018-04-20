using System;

public class AttackCommand : Command
{
    public AttackCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.AttackHero(this.Args);
    }
}
