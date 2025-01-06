namespace Sork;
public interface ICommand
//ties ExitCommand to ICommand
{
    bool Handles(string userinput);
    CommandResult Execute();
}