namespace RockPaperScissors;

public enum PlayerNames
{
    
}

public class Player
{
    public string Name;
    public Player(string n)
    {
        Name = n;
        
        
    }
    public override string ToString() 
    {
        return Name;
    }  
}