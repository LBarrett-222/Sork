// See https://aka.ms/new-console-template for more information
//namespace Sork
//{
public class Program
{
    public static void Main(string[] args)
    {
        do
        { 
                Console.Write(" > ");
                string input = Console.ReadLine();
                input = input.ToLower();
//convert all input to lowercase
                input = input.Trim();
                if (input == "lol") { Console.WriteLine("I tripped over my own foot, looked around, and said lol as if that explained everything."); }
                else if (input == "dance") { Console.WriteLine("I tried to dance, but my shadow filed a formal complaint"); }
                else if (input == "sing") { Console.WriteLine("I sang a note, and the pigeon looked offended while the dog covered its ears."); }
                else if (input == "whistle") { Console.WriteLine("I whistled, and the dog ignored me, but the pigeon looked offended."); }
                else if (input == "exit") { break; }
                else { Console.WriteLine("Dont just stand there, do something"); }
        } while (true);
    }
}
