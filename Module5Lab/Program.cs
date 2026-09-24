using Module5Lab;

Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() + " You have " + player.GetLivesLeft() + " lives left!");

player.Kill();

Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " + player.GetLivesLeft() + " lives left");

SuperPlayer superPlayer = new SuperPlayer();

superPlayer.AddPoints(200);
superPlayer.Fly();

Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");