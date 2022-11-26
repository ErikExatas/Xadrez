using System;
using System.Collections.Generic;
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
                Chess chess = new Chess(8, 8);
                King king = new King(Color.White, chess);
                Rook rook = new Rook(Color.White, chess);
                Queen queen = new Queen(Color.White, chess);
                Knight knight = new Knight(Color.White, chess);
                Bishop bishop = new Bishop(Color.White, chess);
                Pawn pawn = new Pawn(Color.White, chess);
                chess.SetPiece(rook, new Position(0, 0));
                chess.SetPiece(rook, new Position(0, 7));
                chess.SetPiece(knight, new Position(0, 1));
                chess.SetPiece(knight, new Position(0, 6));
                chess.SetPiece(bishop, new Position(0, 2));
                chess.SetPiece(bishop, new Position(0, 5));
                chess.SetPiece(queen, new Position(0, 3));
                chess.SetPiece(king, new Position(0, 4));

                for (int i = 0; i < chess.Rows; i++)
                {
                    for (int j = 0; j < chess.Columns; j++)
                    {
                        chess.SetPiece(pawn, new Position(1, j));
                    }
                }
                Screen.PrintScreen(chess);
                Console.WriteLine();
                chess.GetPiece(1,0);
                Console.WriteLine();
                Console.ReadLine();
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
