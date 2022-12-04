using ChessBoard;
using ChessBoard.Enums;
using ChessBoard.Subclasses;

namespace ChessBoard
{
    internal class Match
    {
        public Chess Chess { get; private set; }
        public int Set { get; private set; }
        public Color CurrentPlayer { get; private set; }

        public Match()
        {
            Chess = new Chess(8,8);
            Set = 1;
            CurrentPlayer = Color.White;
        }
        public void Movement(Position origin, Position final)
        {
            Piece piece = Chess.RemovePiece(Chess.GetPiece(origin), origin);
            piece.Movements();
            Chess.SetPiece(Chess.GetPiece(final), final);
        }
        public void PutPiece()
        {
            King king = new King(Color.White, Chess);
            Rook rook = new Rook(Color.White, Chess);
            Queen queen = new Queen(Color.White, Chess);
            Knight knight = new Knight(Color.White, Chess);
            Bishop bishop = new Bishop(Color.White, Chess);
            Pawn pawn = new Pawn(Color.White, Chess);
            Chess.SetPiece(rook, new ChessMatrix('A', 8).ToPosition());
            Chess.SetPiece(rook, new ChessMatrix('H', 8).ToPosition());
            Chess.SetPiece(knight, new ChessMatrix('B', 8).ToPosition());
            Chess.SetPiece(knight, new ChessMatrix('G', 8).ToPosition());
            Chess.SetPiece(bishop, new ChessMatrix('C', 8).ToPosition());
            Chess.SetPiece(bishop, new ChessMatrix('F', 8).ToPosition());
            Chess.SetPiece(queen, new ChessMatrix('D', 8).ToPosition());
            Chess.SetPiece(king, new ChessMatrix('E', 8).ToPosition());

            for (int i = 0; i < Chess.Rows; i++)
            {
                for (int j = 0; j < Chess.Columns; j++)
                {
                    Chess.SetPiece(pawn, new Position(1, j));
                }
            }

            King king2 = new King(Color.Black, Chess);
            Rook rook2 = new Rook(Color.Black, Chess);
            Queen queen2 = new Queen(Color.Black, Chess);
            Knight knight2 = new Knight(Color.Black, Chess);
            Bishop bishop2 = new Bishop(Color.Black, Chess);
            Pawn pawn2 = new Pawn(Color.Black, Chess);
            Chess.SetPiece(rook2, new Position(7, 0));
            Chess.SetPiece(rook2, new Position(7, 7));
            Chess.SetPiece(knight2, new Position(7, 1));
            Chess.SetPiece(knight2, new Position(7, 6));
            Chess.SetPiece(bishop2, new Position(7, 2));
            Chess.SetPiece(bishop2, new Position(7, 5));
            Chess.SetPiece(queen2, new Position(7, 3));
            Chess.SetPiece(king2, new Position(7, 4));

            for (int i = 0; i < Chess.Rows; i++)
            {
                for (int j = 0; j < Chess.Columns; j++)
                {
                    Chess.SetPiece(pawn2, new Position(6, j));
                }
            }
        }
    }
}
