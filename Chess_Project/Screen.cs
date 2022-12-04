using System;
using ChessBoard;
using ChessBoard.Enums;

namespace Chess_Project
{
    internal class Screen
    {
        public static void PrintScreen(Chess chess)
        {
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < chess.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < chess.Columns; j++)
                {
                    if (chess.GetPiece(i,j) != null )
                    {
                        Print(chess.GetPiece(i, j));
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Print(Piece piece)
        {
            if (piece.Color == Color.Black)
            {
                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                piece.Print();
                Console.ForegroundColor = consoleColor;
            }
            else if (piece.Color == Color.White)
            {
                piece.Print();
            }
        }
    }
}
