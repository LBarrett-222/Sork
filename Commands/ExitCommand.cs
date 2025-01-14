namespace Sork.Commands;
using Sork.World;
public class ExitCommand : BaseCommand
{
    private readonly UserInputOutput io;    
    public ExitCommand(UserInputOutput io)
    {
        this.io = io;
    }
    //using => for shortening the code in the method
    public override bool Handles(string userinput) => GetCommandFromInput(userinput) == "exit";
    public override CommandResult Execute(string userinput, GameState gameState) => new CommandResult { RequestExit = true, IsHandled = true };
//now have access to input string userinput in Execute method
}