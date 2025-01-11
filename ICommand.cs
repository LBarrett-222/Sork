namespace Sork;
using Sork.World;
public interface ICommand
//ties ExitCommand to ICommand
{
    bool Handles(string userinput);
    CommandResult Execute(string userinput, GameState gameState);
}