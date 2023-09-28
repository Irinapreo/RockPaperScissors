
using RockPaperScissors;
// player 1 and 2 write their names
// random start player
// best of 3
// enums for input and win/loss/draw
/* 
bob and billy
ranomizer choses bob to go first
bob choses rock
billy choses scissor
bob wins

var random = new Random();
var x = random.Next(0, names.Length - 1);
*/

Console.WriteLine("Choose your player name.");
Console.WriteLine("Player 1: ");
string name1 = Console.ReadLine();
Player player1 = new Player(name1);

Console.WriteLine("Player 2: ");
string name2 = Console.ReadLine();
Player player2 = new Player(name2);

List<Player> players = new List<Player>()
{
    player1,
    player2,
};
Console.WriteLine();

var random = new Random();
int index = random.Next(players.Count);
Console.WriteLine(players[index]+" will go first.");

Console.WriteLine();


int counter1 = 0;
int counter2 = 0;

while (counter1 < 3 || counter2 < 3)
{
    Console.WriteLine(players[index] + ", chose r, p or s: ");
    var choice1 = Console.ReadLine();
    Console.WriteLine("Player 2, chose r, p or s: ");
    var choice2 = Console.ReadLine();
    Console.WriteLine();
    if (choice1 == "r")
    {
        if (choice2 == "r")
        {
            Console.WriteLine("Draw");
        }
    }
    if (choice1 == "r")
    {
        if (choice2 == "p")
        {
            Console.WriteLine("Player 1 has won this round! ");
        }

        counter2++;

    }
    if (choice1 == "r")
    {
        if (choice2 == "s")
        {
            Console.WriteLine("Player 2 has won this round! ");
        }
        counter1++;
    }
}