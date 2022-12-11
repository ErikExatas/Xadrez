using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Rook : Piece
    {
        public Rook(Color color, Chess chess) : base(color, chess)
        {
        }
        private bool CanMove(Position position)
        {
            Piece piece = Chess.GetPiece(position);
            return piece == null || piece.Color != Color;
        }
        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Chess.Rows, Chess.Columns];
            Position position = new Position(0, 0);

            position.SetPosition(Position.Row - 1, Position.Column);
            while (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Chess.GetPiece(position) != null && Chess.GetPiece(position).Color != Color)
                {
                    break;
                }
                position.Row -= 1;
            }

            position.SetPosition(Position.Row + 1, Position.Column);
            while (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Chess.GetPiece(position) != null && Chess.GetPiece(position).Color != Color)
                {
                    break;
                }
                position.Row += 1;
            }

            position.SetPosition(Position.Row, Position.Column + 1);
            while (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Chess.GetPiece(position) != null && Chess.GetPiece(position).Color != Color)
                {
                    break;
                }
                position.Column += 1;
            }

            position.SetPosition(Position.Row, Position.Column - 1);
            while (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Chess.GetPiece(position) != null && Chess.GetPiece(position).Color != Color)
                {
                    break;
                }
                position.Column -= 1;
            }

            return matrix;
        }
        public override void Print()
        {
            Console.Write("R");
        }
        
    }
}
