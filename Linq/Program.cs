// See https://aka.ms/new-console-template for more information
string[] allGames = new string[] { "Mario", "Poker", "Criciket", "Badminton" };

//foreach (var game in allGames)
//{
//    Console.WriteLine(game);
//}

var videoGamesStartWithB = from game in allGames where game.StartsWith('B') select game;

foreach (var game in videoGamesStartWithB)
{
    Console.WriteLine(game);
}


Console.ReadLine();


