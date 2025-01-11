namespace Sork.World;

public class GameState
{
    public required Player Player { get; set; }
    public required Room RootRoom { get; set; }

    public static GameState Create(UserInputOutput io)
    {
        var tavern = new Room { Name = "Tavern", Description = "A cozy tavern with a friendly atmosphere." };
        var dungeon = new Room { Name = "Dungeon", Description = "A dark and dangerous dungeon." };
        
        tavern.Exits.Add("down", dungeon);
        dungeon.Exits.Add("up", tavern);
    
        io.WritePrompt("Welcome to the game! What is your name?");
        string name = io.ReadInput();

        var player = new Player { Name = name, Location = tavern };
        return new GameState { Player = player, RootRoom = tavern };
    }

}

