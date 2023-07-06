using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourWhoWon.Interface
{
    internal interface IGame
    {
        char Result(char[,] matrix);
        char horizontalCheck(char[,] matrix);
        char verticalCheck(char[,] matrix);
        char diagonalCheck(char[,] matrix);
        bool progressCheck(char[,] matrix);
    }
}
