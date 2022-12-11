using ChessBoard;
using ChessBoard.Enums;
using ChessBoard.Subclasses;
using ChessBoard.Exceptions;
using System.Collections.Generic;

namespace ChessBoard
{
    internal class Match
    {
        public Chess Chess { get; private set; }
        public int Set { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool Finished { get; private set; } = false;
        private bool _time = true;
        HashSet<Piece> pieces = new HashSet<Piece>();

        public Match()
        {
            Chess = new Chess(8, 8);
            Set = 1;
            CurrentPlayer = Color.White;
            PutPiece();
        }
        public void ValidateOriginPosition(Position position)
        {
            if (Chess.GetPiece(position) == null)
            {
                throw new DomainException("There isn't piece in this position");
            }
            if (CurrentPlayer != Chess.GetPiece(position).Color)
            {
                throw new DomainException($"Wait the {CurrentPlayer} piece time");
            }
            if (!(Chess.GetPiece(position).CanMakeMoves()))
            {
                throw new DomainException($"The piece on {Chess.GetPiece(position).Position.ToChessMatrix()} position" +
                    $" can not move");
            }
        }
        public void ValidateFinalPosition(Position origin, Position final)
        {
            if (!(Chess.GetPiece(origin).CanMoveTo(final)))
            {
                throw new DomainException($"The piece on {Chess.GetPiece(origin).Position.ToChessMatrix()} position" +
                    $" can not move to {Chess.GetPiece(final).Position.ToChessMatrix()} position");
            }
        }

        public void Movement(Position origin, Position final)
        {
            Piece piece = Chess.RemovePiece(origin);
            piece.Movements();
            Chess.SetPiece(piece, final);
            Set += 1;
            ChangePlayer(!_time);
            _time = !_time;
        }
        private void ChangePlayer(bool change)
        {
            if (change)
            {
                CurrentPlayer = Color.White;
            }
            else
            {
                CurrentPlayer = Color.Black;
            }
        }
        public void PutNewPiece(Piece piece, char column, int row)
        {
            Chess.SetPiece(piece, new ChessMatrix(column, row).ToPosition());
            pieces.Add(piece);
        }
        private void PutPiece()
        {
            //King king = new King(Color.Black, Chess);
            //Rook rook = new Rook(Color.Black, Chess);
            //Queen queen = new Queen(Color.Black, Chess);
            //Knight knight = new Knight(Color.Black, Chess);
            //Bishop bishop = new Bishop(Color.Black, Chess);
            //Pawn pawn = new Pawn(Color.Black, Chess);
            PutNewPiece(new Rook(Color.Black, Chess), 'A', 8);
            PutNewPiece(new Rook(Color.Black, Chess), 'H', 8);
            //Chess.SetPiece(new Knight(Color.Black, Chess), new ChessMatrix('B', 8).ToPosition());
            //Chess.SetPiece(new Knight(Color.Black, Chess), new ChessMatrix('G', 8).ToPosition());
            //Chess.SetPiece(new Bishop(Color.Black, Chess), new ChessMatrix('C', 8).ToPosition());
            //Chess.SetPiece(new Bishop(Color.Black, Chess), new ChessMatrix('F', 8).ToPosition());
            //Chess.SetPiece(new Queen(Color.Black, Chess), new ChessMatrix('E', 8).ToPosition());
            Chess.SetPiece(new King(Color.Black, Chess), new ChessMatrix('D', 8).ToPosition());

            /*for (int i = 0; i < Chess.Rows; i++)
            {
                for (int j = 0; j < Chess.Columns; j++)
                {
                    Chess.SetPiece(new Pawn(Color.Black, Chess), new Position(1, j));
                }
            }*/

            //King king2 = new King(Color.White, Chess);
            //Rook rook2 = new Rook(Color.White, Chess);
            //Queen queen2 = new Queen(Color.White, Chess);
            //Knight knight2 = new Knight(Color.White, Chess);
            //Bishop bishop2 = new Bishop(Color.White, Chess);
            //Pawn pawn2 = new Pawn(Color.White, Chess);
            Chess.SetPiece(new Rook(Color.White, Chess), new Position(7, 0));
            Chess.SetPiece(new Rook(Color.White, Chess), new Position(7, 7));
            //Chess.SetPiece(new Knight(Color.White, Chess), new Position(7, 1));
            //Chess.SetPiece(new Knight(Color.White, Chess), new Position(7, 6));
            //Chess.SetPiece(new Bishop(Color.White, Chess), new Position(7, 2));
            //Chess.SetPiece(new Bishop(Color.White, Chess), new Position(7, 5));
            //Chess.SetPiece(new Queen(Color.White, Chess), new Position(7, 3));
            Chess.SetPiece(new King(Color.White, Chess), new Position(7, 4));

            /*for (int i = 0; i < Chess.Rows; i++)
            {
                for (int j = 0; j < Chess.Columns; j++)
                {
                    Chess.SetPiece(new Pawn(Color.White, Chess), new Position(6, j));
                }
            }*/
        }
    }
}
