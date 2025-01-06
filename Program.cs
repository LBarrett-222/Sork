// See https://aka.ms/new-console-template for more information
//namespace Sork
//{
namespace Sork;

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