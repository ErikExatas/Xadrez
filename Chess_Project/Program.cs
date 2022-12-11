using System;
using System.Media;
using ChessBoard;
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

                while (!match.Finished)
                {
                    try
                    {
                        Screen.PrintScreen(match.Chess);
                        Console.WriteLine();
                        Console.WriteLine("Set: " + match.Set);
                        Console.WriteLine("Player: " + match.CurrentPlayer);
                        Console.WriteLine();
                        Console.Write("Begin: ");
                        Position origin = Screen.ReadPosition().ToPosition();
                        match.ValidateOriginPosition(origin);

                        bool[,] matrix = match.Chess.GetPiece(origin).PossibleMovements();
                        Console.Clear();
                        Screen.PrintScreen(match.Chess, matrix);
                        Console.WriteLine();
                        Console.WriteLine("Set: " + match.Set);
                        Console.WriteLine("Player: " + match.CurrentPlayer);
                        Console.WriteLine();
                        Console.WriteLine("Begin: " + origin.ToChessMatrix());
                        Console.WriteLine();

                        Console.Write("Final: ");
                        Position final = Screen.ReadPosition().ToPosition();
                        match.ValidateFinalPosition(origin, final);

                        match.Movement(origin, final);
                        Console.Clear();
                    }
                    catch (DomainException ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();  
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Unexpected error: " + ex.Message);
                        Console.WriteLine();
                    }
                }
            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
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
