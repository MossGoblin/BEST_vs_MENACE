using System;
using System.Collections.Generic;
using System.Text;

namespace BEAST_OOp
{
    class MenaceBoard
    {
        // a Dictionary
        // Key: board ID
        // Value - an array of probabilities
        private Dictionary<int, List<int>> boardPool; // dictionary of all accessed boardstates; the reset are considered Default
        private Queue<int> history; // history of selected positions
        private int basePropValue; // base value, used to set up new cells in the pool; will be provided by the SwB, when the class instance is created 

        public int BasePropValue
        {
            get { return basePropValue; }
            set { basePropValue = value; }
        }


        public Queue<int> History
        {
            get { return history; }
            //set { history = value; }
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
            BasePropValue = baseValue;
        }

        // Try to use a boardID

        // Calculate BoardID, based on BoardState
        private int CalculateBoardId(int[] boardState)
        {
            int boardID = 0;
            for (int counter = 9; counter >= 0; counter--)
            {
                int powerFactor = (int)Math.Pow(10, (double)counter);
                boardID += boardState[counter] * powerFactor;
            }
            return boardID;
        }

        // Updating boardPool, if needed (based on a new boardState/boardID)
        public void UpdateMenace(int[] boardState)
        {
            int boardID = CalculateBoardId(boardState);
            List<int> pickList = new List<int>();

            // Check if new state
            if (!BoardPool.ContainsKey(boardID))
            {
                for (int counter = 0; counter <= 9; counter++)
                {
                    pickList.Add(BasePropValue);
                }
                Dictionary<int, List<int>> newPoolItem = new Dictionary<int, List<int>>();
                newPoolItem.Add(boardID, pickList);
            }
        }


        // Make a Move
        public int MakeAMove()
        {
            Random rnd = new Random();
            int newPosition = 0;
            // get a boardName from the boardID
            
            // extract a list of all positive probabilities, according to the boardstate

            // normalize probabilities - create a list of int boundaries to match the random number to

            return newPosition;
        }
    }
}
