using System;

namespace Core.Models
{
    public class Board
    {
        private const int _rows = 3;
        private const int _columns = 3;
        
        private readonly int?[,] _board = new int?[_rows,_columns];

        public int?[,] Get() => _board;

        public bool IsOccupied(int row, int column)
        {
            if (row < 0 || row >= _rows) throw  new ArgumentOutOfRangeException(
                nameof(row), 
                $"Must be between 0 and {_rows-1}."
                );
            
            if (column < 0 || column >= _columns) throw new ArgumentOutOfRangeException(
                nameof(column), 
                $"Must be between 0 and {_columns-1}."
                );

            return _board[row, column] != null;
        }

        public bool PlaceMark(int row, int column, int player)
        {
            if (player < 1 || player > 2) throw new ArgumentOutOfRangeException(
                nameof(column), 
                $"Must be between 1 and 2."
                );
            
            if (IsOccupied(row, column)) return false;
            _board[row, column] = player;
            return true;
        }

        public bool GameOver() => Winner() != null || BoardIsFull();

        public bool BoardIsFull()
        {
            return false;
        }

        public int? Winner()
        {
            return null;
        }
    }
}