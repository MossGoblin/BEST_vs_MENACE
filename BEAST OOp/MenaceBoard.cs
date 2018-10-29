using System;
using System.Collections.Generic;
using System.Text;

namespace BEAST_OOp
{
    /// <summary>
    /// GameBoard class for the "Machine Educable Noughts And Crosses Engine" implementation
    /// </summary>
    class MenaceBoard
    {
        // a Dictionary
        // Key: board ID
        // Value - an array of probabilities

        /// <summary>
        /// A dicitonary of all accessed boardstates
        /// </summary>
        private Dictionary<int, List<int>> boardPool;

        /// <summary>
        /// An int queue, containing the board identity history of all selected positions
        /// </summary>
        private Queue<int> history;

        /// <summary>
        /// A base value for setting up default probability the cells for each board state
        /// </summary>
        private int baseProbabilityIndex;

        public int BaseProbValue
        {
            get { return baseProbabilityIndex; }
            set { baseProbabilityIndex = value; }
        }


        public Queue<int> History
        {
            get
            {
                return history;
            }
            //set
            //{
            //    history. = value;
            //}
        }


        public  Dictionary<int, List<int>> BoardPool
        {
            get
            {
                return boardPool;
            }
            set
            {
                boardPool = value;
            }
        }

        public MenaceBoard(int baseValue)
        {
            // To save memory will most likely init each board state as it is called/updated
            BoardPool = new Dictionary<int, List<int>>();
            // TODO : Muy Importante - load saved BOARD POOL
            BaseProbValue = baseValue;
        }

        // Try to use a boardID

        // Calculate BoardID, based on BoardState
        /// <summary>
        /// Gets the board identity of a provided board grid
        /// </summary>
        /// <param name="boardState">An int array, corresponding to a board grid</param>
        /// <returns>Returns a board identity, corresponding to the provided board grid</returns>
        private int BoardIdFromState(int[] boardState)
        {
            int boardID = 0;
            for (int counter = 9; counter >= 0; counter--)
            {
                int powerFactor = (int)Math.Pow(10, (double)counter);
                boardID += boardState[counter] * powerFactor;
            }
            return boardID;
        }

        // Calculate BoardState, based on BoardID
        /// <summary>
        /// Gets the board grid, corresponding to a provided board identity
        /// </summary>
        /// <param name="boardId">a board identity integer to be used for setting the board grid</param>
        /// <returns>Returns a board grid, based on a provided board identity</returns>
        private int[] BoardStateFromId(int boardId)
        {
            int[] boardState = new int[9];
            int tempNumber = boardId;
            int powerFactor = 9;
            for (int count = 0; count <= 9; count++)
            {
                boardState[count] = boardId - (boardId % (int)Math.Pow(10, powerFactor));
                powerFactor--;
            }
            return boardState;
        }


        // Updating boardPool, if needed (based on a new boardState/boardID)
        public void UpdateMenaceBoard(int[] boardState)
        {
            int boardID = BoardIdFromState(boardState);
            List<int> pickList = new List<int>();

            // Check if new state
            if (!BoardPool.ContainsKey(boardID))
            {
                for (int counter = 0; counter <= 9; counter++)
                {
                    pickList.Add(BaseProbValue);
                }
                Dictionary<int, List<int>> newPoolItem = new Dictionary<int, List<int>>();
                newPoolItem.Add(boardID, pickList);
            }
        }

        // Make a Move
        /// <summary>
        /// Selects a cell for the Menace next move, based on the board identity of the current board state
        /// </summary>
        /// <param name="boardId">a board identity integer to be used for selecting a move</param>
        /// <returns>Returns an integer for a cell in the board grid as a move</returns>
        public int MakeAMove(int boardId)
        {
            Random rnd = new Random();
            int newPosition = 0;
            // get a boardPool from the boardID
            int[] boardState = BoardStateFromId(boardId);
            List<double[]> movePool = new List<double[]>();
            List<int> probabilityPool = boardPool[boardId];
            List<int> shortState = new List<int>();

            for (int counter = 0; counter <= 9; counter++)
            {
                if (probabilityPool[counter] == 0)
                {
                    shortState.Add(probabilityPool[counter]);
                }
            }
            
            // extract a list of all positive probabilities, according to the boardstate

            // normalize probabilities - create a list of int boundaries to match the random number to

            return newPosition;
        }
    }
}
