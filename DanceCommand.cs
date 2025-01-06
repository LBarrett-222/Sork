namespace Sork;
public class DanceCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "dance";
    public CommandResult Execute()
    {
        Console.WriteLine("You Dance!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
