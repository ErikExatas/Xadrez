using System;
using ChessBoard;

namespace Chess_Project
{
    internal class Screen
    {
        public static void PrintScreen(Chess chess)
        {
            for (int i = 0; i < chess.Rows; i++)
            {
                for (int j = 0; j < chess.Columns; j++)
                {
                    if (chess.GetPiece(i,j) != null )
                    {
                        chess.PrintPiece(i, j);
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
    }
}
