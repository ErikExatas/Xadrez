﻿using ChessBoard.Exceptions;

namespace ChessBoard
{
    internal class Chess
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Piece[,] Piece { get; private set; }

        public Chess(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Piece = new Piece[Rows, Columns];
        }
        public Piece GetPiece(int row, int column)
        {
            return Piece[row, column];
        }
        public Piece GetPiece(Position position)
        {
            return Piece[position.Row, position.Column];
        }
        public void SetPiece(Piece piece, Position position)
        {
            if (piece.Position != null)
            {
                throw new DomainException("Already exists piece in this position!");
            }
            Piece[position.Row, position.Column] = piece;
            piece.Position = position;
        }
        public Piece RemovePiece(Position position)
        {
            if (GetPiece(position) == null)
            {
                return null;
            }
            Piece piece = GetPiece(position);
            piece.Position = null;
            Piece[position.Row, position.Column] = null;
            return piece;
        }
        public void PrintPiece(int row, int column)
        {
            Piece[row, column].Print();
        }

        public void PositionException(Position position)
        {
            if (position.Row < 0 || position.Row >= 8 || position.Column < 0 || position.Column >= 8)
            {
                throw new DomainException("Invalid position!");
            }
        }

    }
}
