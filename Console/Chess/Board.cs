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
        private Cell[,] grid = new Cell[8, 8];

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

        // Place Pieces
        public void placePiecesAtDefaultPoistions()
        {
            // Pawns
            for (int i = 0; i < 8; i++)
            {
                grid[1, i].unicode_symbol = Symbol.WHITE_PAWN;
                grid[6, i].unicode_symbol = Symbol.BLACK_PAWN;
            }

            // Rooks
            grid[0, 0].unicode_symbol = Symbol.WHITE_ROOK;
            grid[0, 7].unicode_symbol = Symbol.WHITE_ROOK;
            grid[7, 0].unicode_symbol = Symbol.BLACK_ROOK;
            grid[7, 7].unicode_symbol = Symbol.BLACK_ROOK;

            // Bishops
            grid[0, 2].unicode_symbol = Symbol.WHITE_BISHOP;
            grid[0, 5].unicode_symbol = Symbol.WHITE_BISHOP;
            grid[7, 2].unicode_symbol = Symbol.BLACK_BISHOP;
            grid[7, 5].unicode_symbol = Symbol.BLACK_BISHOP;

            // Knights
            grid[0, 1].unicode_symbol = Symbol.WHITE_KNIGHT;
            grid[0, 6].unicode_symbol = Symbol.WHITE_KNIGHT;
            grid[7, 1].unicode_symbol = Symbol.BLACK_KNIGHT;
            grid[7, 6].unicode_symbol = Symbol.BLACK_KNIGHT;

            // Queens
            grid[0, 3].unicode_symbol = Symbol.WHITE_QUEEN;
            grid[7, 3].unicode_symbol = Symbol.BLACK_QUEEN;

            // Kings
            grid[0, 4].unicode_symbol = Symbol.WHITE_KING;
            grid[7, 4].unicode_symbol = Symbol.BLACK_KING;
        }

        // Display method
        public void displayBoard()
        {
            // Aplhabets Strip
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 8; i++)
            {
                Console.Write(" " + (char)(i + 97) + " ");
            }

            Console.WriteLine("\n --------------------------");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i + 1 + "| ");
                for (int j = 0; j < 8; j++)
                {
                    Console.ResetColor();
                    Console.Write(grid[i, j].unicode_symbol);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" |");
                }
                Console.WriteLine("\n --------------------------");
            }

            Console.ResetColor();

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(grid[i, j].unicode_symbol + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

        // Method - Get symbol
        public string getSymbol(Position position)
        {
            return grid[position.row, position.column].unicode_symbol;
        }

        // Method - Place symbol
        public void placeSymbol(Position position, string symbol)
        {
            grid[position.row, position.column].unicode_symbol = symbol;
        }
    }
}