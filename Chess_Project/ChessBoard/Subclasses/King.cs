using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class King : Piece
    {
        public King(Color color, Chess chess) : base(color, chess)
        {
        }
        public override void Print()
        {
            Console.Write("K");
        }
    }
}
