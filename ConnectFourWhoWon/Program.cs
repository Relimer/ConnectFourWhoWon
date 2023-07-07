using ConnectFourWhoWon.Classes;
using System.Text;
var game = new Game();
char[,] matrix = new char[,]
            {
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' }
            };
int R = 0;

StringBuilder sb = new StringBuilder();
int Y = 0;
do
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (game.Result(matrix) != 'P')
            {
                break;
            }
            Random rnd = new Random();
            int jpos = rnd.Next(matrix.GetLength(1));
            int token = rnd.Next(3);
            if (matrix[i, jpos] != 'R' && matrix[i, jpos] != 'Y')
            {
                if (token == 0 || R <= Y + 1)
                {
                    matrix[i, jpos] = 'R';
                    R++;
                }
                else if (token == 1 || Y <= R + 1)
                {
                    matrix[i, jpos] = 'Y';
                    Y++;
                }
                else
                {
                    matrix[i, jpos] = '-';
                }
            }
            int l = i;
            for (int k = 0; k <= 1; k++)
            {
                if ((i + 1) < matrix.GetLength(0))
                {
                    if (matrix[(i + 1), jpos] == '-')
                    {
                        matrix[(i + 1), jpos] = matrix[i, j];
                        matrix[i, jpos] = '-';
                        i++;
                        k--;
                    }
                }
            }
            i = l;
            for (int m = 0; m < matrix.GetLength(0); m++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    sb.Append(new char[] { matrix[m, n], ' ' });
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
            Console.WriteLine("\nNext Board Position:");
        }
    }
} while (game.Result(matrix) == 'P');
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sb.Append(new char[] { matrix[i, j], ' ' });
    }
    Console.WriteLine(sb.ToString());
    sb.Clear();
}

Console.WriteLine();
Console.WriteLine($"The Winner Is: {game.Result(matrix)}");
