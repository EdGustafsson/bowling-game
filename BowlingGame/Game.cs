using System;
using BowlingGame.Players;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private static IPlayerRepository _playerRepository;
        public Game(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void StartGame(List<string> playerNames)
        {
            int _playerAmount = playerNames.Count;

            for(int player = 0; player < _playerAmount; player++)
            {
               
                    _playerRepository.AddNewPlayer(playerNames[player]);
                
            }
        }

        public void Roll()
        {
            
        }
    }
}
