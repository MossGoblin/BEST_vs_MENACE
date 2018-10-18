using System;
using System.Collections.Generic;

namespace BEAST_OOp
{
    class BeastBoard
    {
        private int[] grid;

        public int[] Grid
        {
            get { return grid; }
            private set { grid = value; }
        }

        public BeastBoard()
        {
            Grid = new int[9];
            for (int cell = 1; cell <= 9; cell++)
            {
                Grid[cell] = 0;
            }
        }

        // BOARD OPERATORS
        // Change board state - update Cell
        public void UpdateBoard(int position, int state)
        {
            // Make a check for valid input
            Grid[position] = state;
        }

        // Retrieve cell state by position
        public int GetCellState(int position)
        {
            return grid[position];
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
            return grid[cellOne] + grid[cellTwo] + grid[cellThree];
        }

        // Extract Board Identity
        public int[] GetBoardIdentity()
        {
            int[] boardID = new int[9];
            for (int counter = 0; counter <= 9; counter++)
            {
                boardID[counter] = Grid[counter];
            }
            return boardID;
        }

        // Set Board State using Board Identity -- check for valid number of changes is handled by SwB; check for valid states is handled by Cell
        public void SetBoardState(int[] boardID)
        {
            for (int counter = 0; counter <= 9; counter++)
            {
                Grid[counter] = boardID[counter];
            }
        }
    }
}
