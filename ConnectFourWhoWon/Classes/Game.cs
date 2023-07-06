using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFourWhoWon.Interface;

namespace ConnectFourWhoWon.Classes
{
    public class Game : IGame
    {
        public char Result(char[,] matrix)
        {
            char horizontal = horizontalCheck(matrix);
            char vertical = verticalCheck(matrix);
            char diagonal = diagonalCheck(matrix);
            bool progress = progressCheck(matrix);

            if ( horizontal == 'R' || vertical == 'R' || diagonal == 'R')
            {
                return 'R';
            } else if ( horizontal == 'Y' || vertical == 'Y' || diagonal == 'Y')
            {
                return 'Y';
            } else if (progress)
            {
                return 'P';
            } else
            {
                return '-';
            }
        }
        public char horizontalCheck(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j + 3 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] == 'R' && matrix[i, j + 1] == 'R' && matrix[i, j + 2] == 'R' && matrix[i, j + 3] == 'R' || 
                            matrix[i, j] == 'Y' && matrix[i, j + 1] == 'Y' && matrix[i, j + 2] == 'Y' && matrix[i, j + 3] == 'Y')
                        {
                            return matrix[i, j];
                        }
                    }
                    
                }
            }
            return '-';
        }
        public char verticalCheck(char[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i + 3 < matrix.GetLength(0))
                    {
                        if (matrix[i, j] == 'R' && matrix[i + 1, j] == 'R' && matrix[i + 2, j] == 'R' && matrix[i + 3, j] == 'R' ||
                            matrix[i, j] == 'Y' && matrix[i + 1, j] == 'Y' && matrix[i + 2, j] == 'Y' && matrix[i + 3, j] == 'Y')
                        {
                            return matrix[i, j];
                        }
                    }

                }
            }
            return '-';
        }
        public char diagonalCheck(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + 3 < matrix.GetLength(0) && j + 3 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] == 'R' && matrix[i + 1, j + 1] == 'R' && matrix[i + 2, j + 2] == 'R' && matrix[i + 3, j + 3] == 'R' ||
                            matrix[i, j] == 'Y' && matrix[i + 1, j + 1] == 'Y' && matrix[i + 2, j + 2] == 'Y' && matrix[i + 3, j + 3] == 'Y')
                        {
                            return matrix[i, j];
                        }
                    } else if (i - 3 > 0 && j + 3 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] == 'R' && matrix[i - 1, j + 1] == 'R' && matrix[i - 2, j + 2] == 'R' && matrix[i - 3, j + 3] == 'R' ||
                            matrix[i, j] == 'Y' && matrix[i - 1, j + 1] == 'Y' && matrix[i - 2, j + 2] == 'Y' && matrix[i - 3, j + 3] == 'Y')
                        {
                            return matrix[i, j];
                        }
                    }

                }
            }
            return '-';
        }
        public bool progressCheck(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '-')
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
