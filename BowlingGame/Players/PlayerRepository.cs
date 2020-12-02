using System;
using System.Collections.Generic;
using System.Text;

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
            Player NewPlayer = new Player(playerName, 0);
            _players.Add(NewPlayer);
        }



    }
}

