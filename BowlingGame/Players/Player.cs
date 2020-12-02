using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame.Players
{
    public class Player
    {
        public Player(string name, int score)
        {     
            Name = name;
            Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
}
