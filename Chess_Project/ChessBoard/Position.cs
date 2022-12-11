namespace ChessBoard
{
    internal class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row; 
            Column = column;
        }
        public void SetPosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
        private char GetLetterColumn(int column)
        {
            if(column == 0)
            {
                return 'A';
            }
            else if (column == 1)
            {
                return 'B';
            }
            else if (column == 2)
            {
                return 'C';
            }
            else if (column == 3)
            {
                return 'D';
            }
            else if (column == 4)
            {
                return 'E';
            }
            else if (column == 5)
            {
                return 'F';
            }
            else if (column == 6)
            {
                return 'G';
            }
            return 'H';
        }
        public ChessMatrix ToChessMatrix()
        {
            return new ChessMatrix(GetLetterColumn(Column), 8 - Row);
        }
        public override string ToString()
        {
            return Row + ", " + Column;
        }
    }
}
