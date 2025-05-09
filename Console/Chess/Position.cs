using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Position
    {
        // Attributes
        public int row, column;

        // Constructor
        public Position(int row = 0, int column = 0)
        {
            this.row = row;
            this.column = column;
        }
    }
}
