using ChessBoard.Enums;

namespace ChessBoard
{
    internal class Piece
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
        public virtual void Print()
        {
        }

    }
}
