namespace Sork.Commands;
using Sork.World;
//abstract class is a class that cannot be instantiated
//should have Handles and Execute methods
public abstract class BaseCommand : ICommand
{
    public abstract bool Handles(string userinput);
    public abstract CommandResult Execute(string userinput, GameState gameState);
    //get the command from the input
    public string GetCommandFromInput(string userinput)
    {
        return userinput.Split(' ')[0].ToLower();
        //split the input into an array of strings based on spaces
        //return the first element of the array and convert it to lowercase
        //Dance Stephen will return dance Oth member, Stephen will be 1st member of the array
        //the 0th part will be returned as dance due to ToLower

    }
    public string[] GetParametersFromInput(string userinput)
    {
        return userinput.Split(' ').Skip(1).ToArray();
        //skip the first element of the array
        //return the rest of the array as a string
    }
}