namespace Sork;
public class ExitCommand : ICommand
{
    //using => for shortening the code in the method
    public bool Handles(string userinput) => userinput == "exit";
    public CommandResult Execute() => new CommandResult { RequestExit = true, IsHandled = true };
}