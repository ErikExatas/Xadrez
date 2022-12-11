using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Pawn : Piece
    {
        public Pawn(Color color, Chess chess) : base(color, chess)
        {
        }
        public override bool[,] PossibleMovements()
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.Write("P");
        }
    }
}
