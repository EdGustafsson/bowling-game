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



            
            a.StartGame(player1, player2);

            List<Player> _players = _playerRepository.GetPlayers();

            Assert.AreEqual(_players.Count, 2);
        }

        [TestMethod]
        public void ScorePlayer_OnePersonGame_ReturnsCorrectScore()
        {
            _playerRepository = new PlayerRepository();
            Game a = new Game(_playerRepository);

            string player1 = "Pelle";
            Round Round1 = new Round();

            a.StartGame(player1);

            Round1.Roll(10);
            Round1.Roll(2);
            Round1.Roll(2);

            a.ScorePlayer(Round1);

            List<Player> _players = _playerRepository.GetPlayers();

            Assert.AreEqual(_players[0].Score, 18);
        }

    }
}
