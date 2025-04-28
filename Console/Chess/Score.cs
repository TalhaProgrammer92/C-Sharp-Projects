using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Score
    {
        // Attributes
        private int score_count = 0;

        // Score getter
        public int getScore()
        {
            return score_count;
        }

        // Score update
        public void updateScore(int score)
        {
            score_count += score;
        }

        // Score reset
        public void resetScore()
        {
            score_count = 0;
        }
    }
}
