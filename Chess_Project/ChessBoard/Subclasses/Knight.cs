using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Knight : Piece
    {
        public Knight(Color color, Chess chess) : base(color, chess)
        {
        }
        public override void Print()
        {
            Console.Write("H");
        }
    }
}
