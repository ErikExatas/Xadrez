using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class King : Piece
    {
        public King(Color color, Chess chess) : base(color, chess)
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
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row - 1, Position.Column + 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row, Position.Column + 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row + 1, Position.Column + 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row + 1, Position.Column);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row + 1, Position.Column - 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row, Position.Column - 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.SetPosition(Position.Row - 1, Position.Column - 1);
            if (Chess.ValidatePosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            return matrix;
        }
        public override void Print()
        {
            Console.Write("K");
        }
    }
}
