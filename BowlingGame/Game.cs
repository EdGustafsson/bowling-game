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

        public void ScorePlayer(Round round1)
        {
            List<Player> _players = _playerRepository.GetPlayers();
            _players[0].Score = round1.Score();
        }

        public void StartRound(Round round1, Round round2)
        {
            List<Player> _players = _playerRepository.GetPlayers();
            _players[0].Score = round1.Score();
            _players[1].Score = round1.Score();
        }

        public void StartRound(Round round1, Round round2, Round round3)
        {
            List<Player> _players = _playerRepository.GetPlayers();
            _players[0].Score = round1.Score();
            _players[1].Score = round1.Score();
            _players[2].Score = round1.Score();
        }

        public void StartRound(Round round1, Round round2, Round round3, Round Round4)
        {
            List<Player> _players = _playerRepository.GetPlayers();
            _players[0].Score = round1.Score();
            _players[1].Score = round1.Score();
            _players[2].Score = round1.Score();
            _players[3].Score = round1.Score();
        }

        public void PrintScores()
        {
        }
    }
}
