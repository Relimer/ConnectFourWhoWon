using ConnectFourWhoWon.Classes;
using System.Text;
var game = new Game();
char[,] matrix = new char[,]
            {
                { 'R', '-', '-', '-', '-', '-', '-' },
                { 'R', '-', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', 'R', 'Y', '-', 'Y', 'Y' },
                { 'R', 'Y', 'R', 'Y', '-', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
            };
StringBuilder sb = new StringBuilder();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sb.Append(new char[] {matrix[i, j], ' ' });  
    }
    Console.WriteLine(sb.ToString());
    sb.Clear();
}

Console.WriteLine();
Console.WriteLine($"The Winner Is: {game.Result(matrix)}");
