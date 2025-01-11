namespace Sork.Commands;
public class WhistleCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public WhistleCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput) => GetCommandFromInput(userinput) == "whistle";
    public override CommandResult Execute()
    {
        io.WriteMessageLine("You whistle!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}