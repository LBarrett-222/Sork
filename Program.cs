// See https://aka.ms/new-console-template for more information
//namespace Sork
//{
using Sork.Commands;
using Sork.World;

namespace Sork;

    public class Program
    {
    public static void Main(string[] args)
    {
        UserInputOutput io = new UserInputOutput();
        var gameState = GameState.Create(io);
        ICommand lol = new LaughCommand(io);
        ICommand exit = new ExitCommand(io);
        ICommand sing = new SingCommand(io);
        ICommand whistle = new WhistleCommand(io);
        ICommand dance = new DanceCommand(io);
        ICommand move = new MoveCommand(io);
        List<ICommand> commands = new List<ICommand> { lol, exit, sing, whistle, dance, move };
      
        do
        { 
                io.WritePrompt(" > ");
                string input = io.ReadInput();
//convert all input to lowercase
                
                var result = new CommandResult { RequestExit = false, IsHandled = false };
                var handled = false;
                foreach (var command in commands)
                {
                    if (command.Handles(input)) 
                    {
                        handled = true;
                        result = command.Execute(input, gameState);
                        if (result.RequestExit) {break; }
                    }
                } 
                if (!handled) { io.WriteMessageLine("unknown Command"); }
                if (result.RequestExit) {break; }            
         }
        while (true);
    }
}
public class UserInputOutput
{
    public void WritePrompt(string prompt) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(prompt);
        Console.ResetColor();
    }
    public void WriteMessage(string message) 
    {
        Console.Write(message);
    }
    public void WriteNoun(string noun) 
    {
        Console.ForegroundColor = ConsoleColor.Blue;    
        Console.Write(noun);
        Console.ResetColor();
    }
    public void WriteMessageLine(string message) 
    {
        Console.WriteLine(message);
    }
    public string ReadInput() 
    {
        return Console.ReadLine().Trim();
    //everywhere we read input, we trim it
    }
    public string ReadKey() 
    {
        return Console.ReadKey().KeyChar.ToString();
    }
}   