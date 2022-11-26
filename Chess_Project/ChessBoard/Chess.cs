namespace ChessBoard
{
    internal class Chess
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Piece[,] Piece { get; private set;}

        public Chess(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Piece = new Piece[Rows, Columns];
        }
        public Piece GetPiece(int row, int column)
        {
            return Piece[row, column];
        }
        public void PrintPiece(int row, int column)
        {
            Piece[row, column].Print();
        }

    }
}
