using System;

public class DayCommand : Command
{
    public DayCommand(string[] args, IGameController gameController) : base(args, gameController)
    {
    }

    public override string Execute()
    {
        return this.GameController.Day();
    }
}