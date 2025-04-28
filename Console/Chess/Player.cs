using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Player
    {
        // Attributes
        public string name { get; }
        public Score score;
        public int won_match, lose_match;

        // Constructor
        public Player(string name)
        {
            this.name = name;
            score = new Score();

            won_match = 0;
            lose_match = 0;
        }

        // Display stats
        public void displayStats()
        {
            // Heading
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"*** {name} Stats ***");

            // Stats
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"\nScore:\t{score.getScore()}\nWon:\t{won_match}\nLose:\t{lose_match}");
            
            Console.ResetColor();
        }
    }
}
