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
                    Print(chess.GetPiece(i, j));
                }
                Console.WriteLine();
            }
        }
        public static void PrintScreen(Chess chess, bool[,] matrix)
        {
            ConsoleColor consoleColor = Console.BackgroundColor;
            ConsoleColor position = ConsoleColor.DarkGray;
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < chess.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < chess.Columns; j++)
                {
                    if (matrix[i, j])
                    {
                        Console.BackgroundColor = position;
                    }
                    else
                    {
                        Console.BackgroundColor = consoleColor;
                    }
                    Print(chess.GetPiece(i, j));
                    Console.BackgroundColor = consoleColor;
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = consoleColor;
        }
        public static ChessMatrix ReadPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1].ToString());
            return new ChessMatrix(column, row);
        }
        public static void Print(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
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
                Console.Write(" ");
            }
            
        }
    }
}
