using System;
using System.Collections.Generic;
using ChessBoard;
using ChessBoard.Subclasses;
using ChessBoard.Enums;

namespace Chess_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Chess chess = new Chess(8, 8);
                King king = new King(Color.White, chess);
                Rook rook = new Rook(Color.White, chess);
                Queen queen = new Queen(Color.White, chess);
                Knight knight = new Knight(Color.White, chess);
                Bishop bishop = new Bishop(Color.White, chess);
                Pawn pawn = new Pawn(Color.White, chess);
                chess.Piece[0, 0] = rook;
                chess.Piece[0, 7] = rook;
                chess.Piece[0, 1] = knight;
                chess.Piece[0, 6] = knight;
                chess.Piece[0, 2] = bishop;
                chess.Piece[0, 5] = bishop;
                chess.Piece[0, 3] = queen;
                chess.Piece[0, 4] = king;
                for (int i = 0; i < chess.Rows; i++)
                {
                    for (int j = 0; j < chess.Columns; j++)
                    {
                        chess.Piece[1, j] = pawn;
                    }
                }
                Screen.PrintScreen(chess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
