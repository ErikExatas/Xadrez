﻿using System;
using ChessBoard.Enums;

namespace ChessBoard.Subclasses
{
    internal class Queen : Piece
    {
        public Queen(Color color, Chess chess) : base(color, chess)
        {
        }
        public override void Print()
        {
            Console.Write("Q");
        }
    }
}
