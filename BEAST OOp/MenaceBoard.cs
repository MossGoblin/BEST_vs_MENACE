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
        private Dictionary<int, List<int>> boardPool;
        private List<int> history;
        int[] tt1 = { 1, 2, 3 };
        int[] tt2 = { 1, 2, 3 };

        public List<int> History
        {
            get { return history; }
            set { history = value; }
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

        public MenaceBoard()
        {
            // TODO : Menace : Init BoardPool ??
            // To save memory will most likely init each board state as it is called/updated
            BoardPool = new Dictionary<int, List<int>>();
        }

        // TODO : Menace : Update BoardState

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
