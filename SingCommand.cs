namespace Sork;
public class SingCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "sing";
    public CommandResult Execute()
    {
        Console.WriteLine("You Sing!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}