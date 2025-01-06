// See https://aka.ms/new-console-template for more information
//namespace Sork
//{
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        ICommand lol = new LaughCommand();
        ICommand exit = new ExitCommand();
        ICommand sing = new SingCommand();
        ICommand whistle = new WhistleCommand();
        ICommand dance = new DanceCommand();
        List<ICommand> commands = new List<ICommand> { lol, exit, sing, whistle, dance };
      
        do
        { 
                Console.Write(" > ");
                string input = Console.ReadLine();
                input = input.ToLower();
//convert all input to lowercase
                input = input.Trim();
                var result = new CommandResult { RequestExit = false, IsHandled = false };
                var handled = false;
                foreach (var command in commands)
                {
                    if (command.Handles(input)) 
                    {
                        handled = true;
                        result = command.Execute();
                        if (result.RequestExit) {break; }
                    }
                } 
                if (!handled) { Console.WriteLine("unknown Command"); }
                if (result.RequestExit) {break; }          
         //using foreach to iterate thru list takes care of the else if and else statements except unknown  
         //    else if (sing.Handles(input)) {if (sing.Execute().RequestExit) { break;}}          
        //     else if (whistle.Handles(input)) {if (whistle.Execute().RequestExit) { break;}}
         //    else if (dance.Handles(input)) {if (dance.Execute().RequestExit) { break;}}
        //     else if (exit.Handles(input)) {if (exit.Execute().RequestExit) { break;}}          
        //     else { Console.WriteLine("unknown Command"); }
         }
        while (true);
    }
}
public interface ICommand
//ties ExitCommand to ICommand
{
    bool Handles(string userinput);
    CommandResult Execute();
}
public class SingCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "sing";
    public CommandResult Execute()
    {
        Console.WriteLine("You Sing!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
public class WhistleCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "whistle";
    public CommandResult Execute()
    {
        Console.WriteLine("You whistle!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}

public class DanceCommand : ICommand
{
    public bool Handles(string userinput) => userinput == "dance";
    public CommandResult Execute()
    {
        Console.WriteLine("You Dance!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
public class ExitCommand : ICommand
{
    //using => for shortening the code in the method
    public bool Handles(string userinput) => userinput == "exit";
    public CommandResult Execute() => new CommandResult { RequestExit = true, IsHandled = true };
}
//this command says, when I'm done, I want the program to end
public class CommandResult
//2 properties, RequestExit and IsHandled; used whenever we execute  
{
    public bool RequestExit { get; set; }
    public bool IsHandled { get; set; }
}
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