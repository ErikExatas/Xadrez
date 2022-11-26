using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Rook : Piece
    {
        public Rook(Color color, Chess chess) : base(color, chess)
        {
        }
        public override void Print()
        {
            Console.Write("R");
        }
    }
}
