namespace Sork.Commands;
using Sork.World;
public class DanceCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public DanceCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput) {
        var paramsLength = GetParametersFromInput(userinput).Length;
        return  GetCommandFromInput(userinput) == "dance" && (paramsLength == 0 || paramsLength == 1);
    }
    //if parm length is 0 or 1, return true
    //create paramslength to avoid using GetParametersFromInput(userinput) twice
    public override CommandResult Execute(string userinput, GameState gameState)
    //now have access to input string userinput in Execute method
    {
        var parameters = GetParametersFromInput(userinput);
        if (parameters.Length == 0)
        {
            io.WriteNoun("You");
            io.WriteMessageLine(" dance!");
        }
        else
        {
            io.WriteNoun("You");
            io.WriteMessage(" dance with ");
            io.WriteNoun(parameters[0]);
            io.WriteMessageLine("!");
        }
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
