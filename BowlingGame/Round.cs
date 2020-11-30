using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Round
    {

        int score;
        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }
    }
}
