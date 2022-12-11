using ChessBoard.Enums;

namespace ChessBoard
{
    internal abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Movement { get; protected set; } = 0;
        public Chess Chess { get; protected set; }

        public Piece(Color color, Chess chess)
        {
            Color = color;
            Chess = chess;
        }
        public void Movements()
        {
            Movement++;
        }
        public void SubMovements()
        {
            Movement--;
        }
        public bool CanMakeMoves()
        {
            bool[,] matrix = PossibleMovements();
            for (int i = 0; i < Chess.Rows; i++)
            {
                for (int j = 0; j < Chess.Columns; j++)
                {
                    if (matrix[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CanMoveTo(Position position)
        {
            return PossibleMovements()[position.Row, position.Column];
        }
        public abstract bool[,] PossibleMovements();
        public abstract void Print();


    }
}
