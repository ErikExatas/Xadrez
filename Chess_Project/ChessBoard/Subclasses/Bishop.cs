using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Bishop : Piece
    {
        public Bishop(Color color, Chess chess) : base(color, chess)
        {
        }
        public override bool[,] PossibleMovements()
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.Write("B");
        }
    }
}
