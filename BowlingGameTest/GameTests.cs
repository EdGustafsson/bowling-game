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
        public void CanPlayOnePersonGame()
        {
            _playerRepository = new PlayerRepository();
            Game a = new Game(_playerRepository);

            string player1 = "Pelle";
         
            a.StartGame(player1);

            a.StartGame();

            List<Player> _players = _playerRepository.GetPlayers();

            Assert.AreEqual(_players[0].Score, 40);
        }

    }
}
