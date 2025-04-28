using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Cell
    {
        // Attributes
        public string unicode_symbol;
        private Position position;

        // Constructor
        public Cell(string unicode_symbol, Position position)
        {
            this.unicode_symbol = unicode_symbol;
            this.position = position;
        }

        // Getter
        public Position getPosition()
        {
            return position;
        }
    }
}
