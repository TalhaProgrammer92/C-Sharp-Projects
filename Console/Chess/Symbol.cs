using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Symbol
    {
        // White Chess Pieces
        public const string BLACK_PAWN = "♙";
        public const string BLACK_ROOK = "♖";
        public const string BLACK_KNIGHT = "♘";
        public const string BLACK_BISHOP = "♗";
        public const string BLACK_QUEEN = "♕";
        public const string BLACK_KING = "♔";

        // Black Chess Pieces
        public const string WHITE_PAWN = "♟";
        public const string WHITE_ROOK = "♜";
        public const string WHITE_KNIGHT = "♞";
        public const string WHITE_BISHOP = "♝";
        public const string WHITE_QUEEN = "♛";
        public const string WHITE_KING = "♚";

        // Empty Boxes
        public const string EMPTY_BOX_BLACK = "o";
        public const string EMPTY_BOX_WHITE = ".";

        // Method to set UTF-8
        public static void setUtf8()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        // Method to get empty cell for board
        public static string getEmptyCell(Position position)
        {
            if (position.row % 2 == 0)
            {
                return position.column % 2 == 0 ? EMPTY_BOX_WHITE : EMPTY_BOX_BLACK;
            }
            else
            {
                return position.column % 2 == 0 ? EMPTY_BOX_BLACK : EMPTY_BOX_WHITE;
            }
        }
    }
}
