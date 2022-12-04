using System;
using ChessBoard;
using ChessBoard.Subclasses;
using ChessBoard.Enums;
using ChessBoard.Exceptions;

namespace Chess_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Match match = new Match();
                match.PutPiece();

                Screen.PrintScreen(match.Chess);
                Console.WriteLine();
                ChessMatrix chessMatrix = new ChessMatrix('C', 7);
                Console.WriteLine(chessMatrix);
                Console.WriteLine(chessMatrix.ToPosition());
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Position error: " + ex.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
                Console.WriteLine();
            }
            
        }
    }
}
