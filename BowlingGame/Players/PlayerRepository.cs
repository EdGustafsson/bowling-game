using System;
using System.Collections.Generic;
using System.Text;
using BowlingGame;

namespace BowlingGame.Players
{
    public class PlayerRepository : IPlayerRepository
    {

        private readonly List<Player> _players = new List<Player>();
        public PlayerRepository()
        {


        }


        public List<Player> GetPlayers()
        {
            return _players;
        }

        public void AddNewPlayer(string playerName)
        {
            Round NewRound = new Round();
            Player NewPlayer = new Player(playerName, NewRound);
            _players.Add(NewPlayer);
        }



    }
}

