namespace Sork.Commands;
public class SingCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public SingCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput) => GetCommandFromInput(userinput) == "sing";
    public override CommandResult Execute()
    {
        io.WriteMessageLine("You Sing!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}