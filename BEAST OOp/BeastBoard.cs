using System;
using System.Collections.Generic;

namespace BEAST_OOp
{
    /// <summary>
    /// GameBoard class for the BEst Available STrategy implementation
    /// </summary>
    class BeastBoard
    {
        /// <summary>
        /// Main GameBoard grid - a 9 cell int array, holding 0, 1 or 2 for 'empty', 'Beast' or 'Menace'
        /// </summary>
        private int[] grid;

        public int[] Grid
        {
            get { return grid; }
            private set { grid = value; }
        }

        public BeastBoard()
        {
            Grid = new int[9];
            //Initialize grid
            for (int cell = 1; cell <= 9; cell++)
            {
                Grid[cell] = 0;
            }
        }

        // BOARD OPERATORS
        // Change board state - update Cell
        /// <summary>
        /// Updates the Beast GameBoard by changing the value of a cell at 'position' to a 'state'
        /// </summary>
        /// <param name="position">a cell in the board grid array (0-9) that is to be changed</param>
        /// <param name="state">a new state (0, 1, 2) for the given <italic>position</italic> in the board grid</param>
        public void UpdateBoard(int position, int state)
        {
            // Make a check for valid input
            Grid[position] = state;
        }

        // Gets cell state by position
        /// <summary>
        /// Returns the state of a given cell in the board grid
        /// </summary>
        /// <param name="position">a cell in the board grid array (0-9)</param>
        /// <returns>an integer (0, 1, 2), equal to the state of a given cell</returns>
        public int GetCellState(int position)
        {
            return grid[position];
        }

        /// <summary>
        /// Calculates the sum of a given line in the board grid
        /// </summary>
        /// <param name="lNum">a numerical index (0-8) for the line which sum is to be calculated</param>
        /// <returns>Returns the sum of a given line in the board grid</returns>
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

        /// <summary>
        /// Calculates the Board Identity (int), corresponding to the current board grid
        /// </summary>
        /// <returns>Returns an ineger value, representing the BoardIdentity</returns>
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

        /// <summary>
        /// Sets the board grid, based on a provided Board Identity
        /// </summary>
        /// <param name="boardID">a Board Identity integer to be used for setting the board grid</param>
        // Set Board State using Board Identity -- check for valid number of changes is handled by SwB
        public void SetBoardState(int[] boardID)
        {
            for (int counter = 0; counter <= 9; counter++)
            {
                Grid[counter] = boardID[counter];
            }
        }
    }
}
