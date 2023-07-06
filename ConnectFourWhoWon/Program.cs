using ConnectFourWhoWon.Classes;
var game = new Game();
char[,] matrix = new char[,]
            {
                { 'R', 'R', 'Y', 'R', 'Y', 'Y', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'Y', 'R', 'R' },
                { 'Y', 'Y', 'R', 'R', 'R', 'Y', 'R' },
                { 'R', 'Y', 'Y', 'Y', 'R', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
            };
Console.WriteLine(game.Result(matrix));
