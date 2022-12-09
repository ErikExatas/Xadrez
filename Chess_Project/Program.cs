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

                while (!match.Finished)
                {
                    Screen.PrintScreen(match.Chess);
                    Console.WriteLine();
                    Console.Write("Begin: ");
                    Position origin = Screen.ReadPosition().ToPosition();
                    Console.Write("Final: ");
                    Position final = Screen.ReadPosition().ToPosition();
                    match.Movement(origin, final);
                    Console.Clear();
                }
                
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
