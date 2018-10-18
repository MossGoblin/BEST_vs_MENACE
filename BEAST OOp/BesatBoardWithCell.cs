using System;
using System.Collections.Generic;

namespace BEAST_OOp
{
    class BeastBoardWithCells
    {
        private Dictionary<int, Cell> grid;

        public Dictionary<int, Cell> Cells
        {
            get { return grid; }
            private set { grid = value; }
        }

        public BeastBoardWithCells()
        {
            for (int count = 1; count <= 9; count++)
            {
                Cell newCell = new Cell(0);
                Cells.Add(count, newCell);
            }
        }
        
        // BOARD OPERATORS
        // Change board state - update Cell
        public void UpdateBoard(int position, int state)
        {
           Cells[position].State = state;
        }

        // Retrieve cell state by position
        public int GetCellState(int position)
        {
            return grid[position].State;
        }
        
        // Retrieve the state of a line number
        public int GetLineSum(int lNum)
        {
            // Line definitions
            // 1, 2, 3
            // 4, 5, 6
            // 7, 8, 9
            // 1, 4, 7
            // 2, 5, 8
            // 3, 6, 9
            // 1, 5, 9
            // 3, 5, 7

            int[,] lineDefs = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 },
            { 1, 5, 9 },
            { 3, 5, 7 },
            };

            int cellOne = lineDefs[lNum, 0];
            int cellTwo = lineDefs[lNum, 1];
            int cellThree = lineDefs[lNum, 2];
            return grid[cellOne].State + grid[cellTwo].State + grid[cellThree].State;
        }

        // Extract Board Identity
        public int[] GetBoardIdentity()
        {
            int[] boardID = new int[9];
            for (int counter = 0; counter <= 0; counter++)
            {
                boardID[counter] = Cells[counter].State;
            }
            return boardID;
        }

        // Set Board State using Board Identity -- check for valid number of changes is handled by SwB; check for valid states is handled by Cell
        public void SetBoardState(int[] boardID)
        {
            for (int counter = 0; counter <= 0; counter++)
            {
                Cells[counter].State = boardID[counter];
            }
        }
    }
}
