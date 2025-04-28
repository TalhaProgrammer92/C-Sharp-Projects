using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        // Attributes
        public Cell[,] grid = new Cell[8, 8];

        // Constructor
        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grid[i, j] = new Cell(Symbol.getEmptyCell(new Position(i, j)), new Position(i, j));
                }
            }
        }

        // Clear Board
        public void clearBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grid[i, j].unicode_symbol = Symbol.getEmptyCell(new Position(i, j));
                }
            }
        }

        // Display method
        public void displayBoard()
        {
            Console.WriteLine("  a b c d e f g h");
            Console.WriteLine("  -----------------");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i + 1 + "|");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(grid[i, j].unicode_symbol + "|");
                }
                Console.WriteLine();
            }
        }
    }
}