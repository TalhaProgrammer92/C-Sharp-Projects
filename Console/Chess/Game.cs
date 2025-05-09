using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Game
    {
        // Attributes
        public Player[] players;
        public Board board;
        private bool game_over;
        private bool turn;
        public Position[] position;

        // Constructor
        public Game(Player[] players, Board board)
        {
            this.players = players;
            this.board = board;
            this.game_over = false;
            this.turn = false;
            this.position = new Position[players.Length];
        }

        // Method - Update turn
        public void updateTurn()
        {
            turn = !turn;
        }

        // Method - Take input
        public string takeInput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            return Console.ReadLine();
        }

        // Method - Is valid code
        public bool isValidCode(string code)
        {
            return code.Length == 2 && Char.IsAsciiDigit(code[0]) && code[0] != '0' && code[1] >= 'a' && code[2] <= 'h';
        }

        // Method - Update Position
        public void updatePosition(string code, int index = 0 /* 0-Piece position, 1-Destination position */)
        {
            position[index] = new Position(Convert.ToInt32(code[0]), code[1] - 'a');
        }

        // Method - Move Piece
        public void movePiece()
        {
            // Get the chess piece
            string piece = board.getSymbol(position[0]);

            // Place it
            board.placeSymbol(position[1], piece);
            board.placeSymbol(position[0], Symbol.getEmptyCell(position[0]));
        }
    }
}
