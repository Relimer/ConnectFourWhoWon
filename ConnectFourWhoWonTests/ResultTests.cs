using ConnectFourWhoWon.Classes;

using FluentAssertions;
using Xunit;

namespace ConnectFourWhoWonTests
{
    public class ResultTests
    {
     [Fact]
        public void GameResult_Should_Output_Winning_Char_Horizontal()
        {
            char[,] matrix = new char[,]
            {
                /*{ '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'R', 'R', 'R', 'R' },
                { '-', '-', '-', 'Y', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'R' }
                char winningChar = 'R';*/
                /*{ 'R', 'R', 'R', 'R', 'Y', 'Y', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'Y', 'R', 'R' },
                { 'Y', 'Y', 'R', 'R', 'Y', 'Y', 'R' },
                { 'R', 'Y', 'Y', 'Y', 'R', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
                char winningChar = 'R';*/
                /*{ 'R', '-', '-', '-', '-', '-', '-' },
                { 'R', '-', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', 'Y', 'Y', '-', 'Y', 'R' },
                { 'R', 'Y', 'R', 'Y', '-', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
                char winningChar = 'Y';*/
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', '-', '-', '-', '-', '-' },
                { 'Y', 'R', 'Y', 'Y', '-', '-', '-' },
                { 'R', 'R', 'R', 'R', '-', '-', '-' }
            };
            char winningChar = 'R';
            var result = new Game().horizontalCheck(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Winning_Char_Vertical ()
        {
            char[,] matrix = new char[,]
            {
                /*{ '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'Y', 'R', 'R', 'R' },
                { '-', '-', '-', 'Y', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'R' }
                char winningChar = 'Y';*/
                /*{ 'R', 'Y', 'R', 'R', 'Y', 'Y', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'Y', 'R', 'R' },
                { 'Y', 'Y', 'R', 'R', 'Y', 'Y', 'R' },
                { 'R', 'Y', 'Y', 'Y', 'R', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
                char winningChar = 'R';*/
                /*{ 'R', '-', '-', '-', '-', '-', '-' },
                { 'R', '-', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', 'R', 'Y', '-', 'Y', 'Y' },
                { 'R', 'Y', 'R', 'Y', '-', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
                char winningChar = 'Y';*/
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', '-', '-', '-', '-', '-' },
                { 'Y', 'Y', '-', '-', '-', '-', '-' },
                { 'Y', 'R', 'Y', 'R', '-', '-', '-' },
                { 'Y', 'R', 'R', 'R', '-', '-', '-' }
            };
            char winningChar = 'Y';
            var result = new Game().verticalCheck(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Winning_Char_DiagonalLeft()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'R', 'R', 'Y', 'R' },
                { '-', '-', '-', 'Y', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'R' }
            };
            char winningChar = 'Y';
            var result = new Game().diagonalCheck(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Winning_Char_DiagonalRight()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'Y', 'R', 'R', 'R' },
                { '-', '-', '-', 'R', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'Y' }
            };
            char winningChar = 'Y';
            var result = new Game().diagonalCheck(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Winning_Char()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'R', 'R', 'R', 'R' },
                { '-', '-', '-', 'Y', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'R' }
            };
            char winningChar = 'R';
            var result = new Game().Result(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Progress()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', '-', '-', '-', '-' },
                { '-', '-', '-', 'R', 'Y', 'R', 'R' },
                { '-', '-', '-', 'Y', 'Y', 'R', 'Y' },
                { '-', '-', '-', 'Y', 'R', 'Y', 'Y' },
                { '-', '-', 'Y', 'Y', 'R', 'R', 'R' }
            };
            char winningChar = 'P';
            var result = new Game().Result(matrix);
            result.Should().Be(winningChar);
        }
        [Fact]
        public void GameResult_Should_Output_Draw()
        {
            char[,] matrix = new char[,]
            {
                { 'R', 'R', 'Y', 'R', 'Y', 'Y', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'Y', 'R', 'R' },
                { 'Y', 'Y', 'R', 'R', 'R', 'Y', 'R' },
                { 'R', 'Y', 'Y', 'Y', 'R', 'R', 'Y' },
                { 'R', 'R', 'Y', 'R', 'Y', 'R', 'Y' },
                { 'R', 'Y', 'Y', 'R', 'R', 'R', 'Y' }
            };
            char winningChar = '-';
            var result = new Game().Result(matrix);
            result.Should().Be(winningChar);
        }
    }
}