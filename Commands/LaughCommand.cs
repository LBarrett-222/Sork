namespace Sork.Commands;
using Sork.World;
public class LaughCommand : BaseCommand
//examine a piece of input, then do the command
//create 2 methods, Handles and Execute
//dependency injection is when we pass an object into a class as a parameter
//constructor METHOD is when we pass an object into a class as a parameter
{
    private readonly UserInputOutput io;
// can only be set on creation
    public LaughCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userinput)
    {
        return GetCommandFromInput(userinput) == "lol";
    }
    public override CommandResult Execute(string userinput, GameState gameState)
    //when replaceing void with CommandResult in Execute, we can return a new CommandResult object
    //and the return new CommandResult is the object we're returning
    //now have access to input string userinput in Execute method
    {
        var parameters = GetParametersFromInput(userinput);
        if (parameters.Length == 0)
        {
            io.WriteNoun("You");
            io.WriteMessageLine(" laugh out loud!");
        }
        else
        {
            io.WriteNoun("You");
            io.WriteMessage(" laugh out loud with ");
            io.WriteNoun(parameters[0]);
            io.WriteMessageLine("!");
        }
    
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}