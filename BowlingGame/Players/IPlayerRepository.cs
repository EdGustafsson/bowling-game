using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame.Players
{
    public interface IPlayerRepository
    {

        List<Player> GetPlayers();
        void AddNewPlayer(String playerName);
    }



}
