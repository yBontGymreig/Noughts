using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noughts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Noughts...");
            char[,] board = {
                                {'x','o','x'},
                                {'o','o','o'},
                                {' ',' ',' '}
            };
            char[] symbols = { 'x', 'o' };
            PrintBoard(board);
            //TODO GAME ALGORITHM
            Console.WriteLine("Coming soon: version 0.1 of our minty pollux.");
            GetHorizontalWinner(board);
            Console.ReadLine(); //wait for enter key

        }

        /// <summary>Method <c>IsValidMove</c> rerturns true if move can be made on rwo major board.</summary>
        static bool IsValidMove(char[,] board, int row, int column)
        {
            throw new NotImplementedException();
        }

        /// <summary>Method <c>IsBoardFull</c> returns true if board is full of chars that aren't spaces.</summary>
        static bool IsBoardFull(char[,] board)
        {
            throw new NotImplementedException();
        }

        /// <summary>Method <c>WinningPlayer</c> returns char of winning player, or an empty string of no winner.</summary>
        static char GetWinningPlayer(char[,] board)
        {
            throw new NotImplementedException();
        }

        /// <summary>Method <c>GetVerticalWinner</c> returns char of winning player, or an empty string if no winner.</summary>
        static char GetVerticalWinner(char[,] board)
        {
         throw new NotImplementedException();
        }

        /// <summary>Method <c>GetDiagonalWinner</c> returns char of winning player, or an empty string if no winner.</summary>
        static char GetDiagonalWinner(char[,] board)
        {
            throw new NotImplementedException();
        }

        /// <summary>Method <c>GetHorizontalWinner</c> returns char of winning player, or an empty string if no winner.</summary>
        static char GetHorizontalWinner(char[,] board)
        {
             for (int row = 0; row < board.GetLength(0); row++)
             {
               if  (board[row,0]!=' ' && board[row, 0] == board[row, 1] && board[row, 0] == board[row, 2])
                {
                   Console.WriteLine("winner");
                   return board[0, 0];
                }
                    

             }
             return ' ';
       
        }
        

        /// <summary>Procedure <c>InputMove</c> Asks the player for a row and column until valid ones are given, then updates the board.</summary>
        static void InputMove(char[,] board, char symbol)
        {
            throw new NotImplementedException();
        }

        /// <summary>Procedure <c>PrintBoard</c> Prints the current state of the board.</summary>

        static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    Console.Write("|" + board[row, column]);
                }
                Console.Write("|\n");
            }
            Console.WriteLine("\n**********************************\n");

        }
    }

}
