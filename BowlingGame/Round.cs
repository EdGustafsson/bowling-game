using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Round
    {
        int[] rolls = new int[21];
        int currentRoll;

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score()
        {
            int roll = 0;
            int score = 0;
        
            for(int frame = 0; frame < 10; frame++)
            {
                if (rolls[roll] == 10)
                {
                    score += 10 + rolls[roll + 1] + rolls[roll + 2];
                    roll++;
                }
                if (rolls[roll] + rolls[roll+1] == 10)
                {
                    score += 10 + rolls[roll + 2];
                    roll += 2;
                }
                else
                {
                    score += rolls[roll] + rolls[roll + 1];
                    roll += 2;
                }
            }

            return score;

        }
    }
}
