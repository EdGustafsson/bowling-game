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


        public string Name { get; set; }

        public void StartGame(string player1)
        {
           

            _playerRepository.AddNewPlayer(player1);

        }
        public void StartGame(string player1, string player2)
        {
            _playerRepository.AddNewPlayer(player1);
            _playerRepository.AddNewPlayer(player2);
        }

        public void StartGame(string player1, string player2, string player3)
        {
            _playerRepository.AddNewPlayer(player1);
            _playerRepository.AddNewPlayer(player2);
            _playerRepository.AddNewPlayer(player3);
        }

        public void StartGame(string player1, string player2, string player3, string player4)
        {
            _playerRepository.AddNewPlayer(player1);
            _playerRepository.AddNewPlayer(player2);
            _playerRepository.AddNewPlayer(player3);
            _playerRepository.AddNewPlayer(player4);
        }
    }
}
