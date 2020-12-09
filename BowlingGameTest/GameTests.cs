using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame.Players;
using System.Collections.Generic;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTests
    {
        private static IPlayerRepository _playerRepository;

        [TestMethod]
        public void CanSelectPlayerAmount()
        {
            _playerRepository = new PlayerRepository();


            string player1 = "Pelle";
            string player2 = "Anders";

            Game a = new Game(_playerRepository);

            List<string> players = new List<string>();

            players.Add(player1);
            players.Add(player2);

            a.StartGame(players);

            List<Player> _players = _playerRepository.GetPlayers();

            Assert.AreEqual(_players.Count, 2);
        }

        [TestMethod]
        public void PlayerRound_OnePersonGame_ReturnsCorrectScore()
        {
            _playerRepository = new PlayerRepository();
            Game a = new Game(_playerRepository);

            string player1 = "Pelle";

            List<string> players = new List<string>();

            players.Add(player1);

            a.StartGame(players);

            List<Player> _players = _playerRepository.GetPlayers();

            _players[0].Round.Roll(10);
            _players[0].Round.Roll(2);
            _players[0].Round.Roll(2);

            Assert.AreEqual(_players[0].Round.Score(), 18);
        }

        //[TestMethod]
        //public void Round_Active_ReturnsCorrect()
        //{
        //    _playerRepository = new PlayerRepository();
        //    Game a = new Game(_playerRepository);

        //    string player1 = "Pelle";
        //    string player2 = "Anders";

        //    a.StartGame(player1, player2);

        //    List<Player> _players = _playerRepository.GetPlayers();

        //    bool x = true;

        //    Assert.AreEqual(x, _players[0].Round.Active);

        //}

        //[TestMethod]
        //public void Round_Active_Shift()
        //{
        //    _playerRepository = new PlayerRepository();
        //    Game a = new Game(_playerRepository);

        //    string player1 = "Pelle";
        //    string player2 = "Anders";

        //    a.StartGame(player1, player2);

        //    List<Player> _players = _playerRepository.GetPlayers();

        //    bool x = true;

        //    Assert.AreEqual(x, _players[0].Round.Active);

        //}
    }
}
