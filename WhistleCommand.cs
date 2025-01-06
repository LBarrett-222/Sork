namespace Sork;
public class WhistleCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "whistle";
    public CommandResult Execute()
    {
        Console.WriteLine("You whistle!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}