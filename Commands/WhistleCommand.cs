namespace Sork.Commands;
using Sork.World;
public class WhistleCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public WhistleCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput) => GetCommandFromInput(userinput) == "whistle";
    public override CommandResult Execute(string userinput, GameState gameState)
    {
        var parameters = GetParametersFromInput(userinput);
        if (parameters.Length == 0)
        {
            io.WriteNoun("You");
            io.WriteMessageLine(" whistle!");
        }
        else
        {
            io.WriteNoun("You");
            io.WriteMessage(" whistle with ");
            io.WriteNoun(parameters[0]);
            io.WriteMessageLine("!");
        }
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}