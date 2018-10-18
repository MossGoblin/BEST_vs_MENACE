using System;
using System.Collections.Generic;
using System.Text;

namespace BEAST_OOp
{
    class Cell
    {
        private int state;

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public Cell(int state)
        {
            if (state >= 0 && state < 3)
            {
                State = state;
            }
            else
            {
                throw new System.ArgumentException("State can be only 0, 1 or 1", "state");
            }
        }
    }
}
