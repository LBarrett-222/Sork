namespace Sork.Commands;
using Sork.World;
public class SingCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public SingCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput) => GetCommandFromInput(userinput) == "sing";
    public override CommandResult Execute(string userinput, GameState gameState)
    //now have access to input string userinput in Execute method
    {
        var parameters = GetParametersFromInput(userinput);
        if (parameters.Length == 0)
        {
            io.WriteNoun("You");
            io.WriteMessageLine(" sing!");
        }
        else
        {
            io.WriteNoun("You");
            io.WriteMessage(" sing with ");
            io.WriteNoun(parameters[0]);
            io.WriteMessageLine("!");
        }
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}