namespace ChessBoard
{
    internal class ChessMatrix
    {
        public char Column { get; private set; }
        public int Line { get; private set; }

        public ChessMatrix(char column, int line)
        {
            Column = column;
            Line = line;
        }
        public Position ToPosition()
        {
            return new Position(8 - Line, Column - 'A');
        }
        public override string ToString()
        {
            return Column.ToString() + Line.ToString();
        }
    }
}
