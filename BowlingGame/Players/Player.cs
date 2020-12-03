using System;
using System.Collections.Generic;
using System.Text;
using BowlingGame;

namespace BowlingGame.Players
{
    public class Player
    {

        public Player(string name, Round round)
        {     
            Name = name;
            Round = round;
        }

        public string Name { get; set; }
        public Round Round { get; set; }
    }
}
