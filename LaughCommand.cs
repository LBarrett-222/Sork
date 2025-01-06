namespace Sork;
public class LaughCommand : ICommand
//examine a piece of input, then do the command
//create 2 methods, Handles and Execute
{
    public bool Handles(string userinput)
    {
        return userinput == "lol";
    }
    public CommandResult Execute()
    //when replaceing void with CommandResult in Execute, we can return a new CommandResult object
    //and the return new CommandResult is the object we're returning
    {
        Console.WriteLine("You laugh out loud!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}