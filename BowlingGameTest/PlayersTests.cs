using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame.Players;
using System.Collections.Generic;

namespace BowlingGameTest
{
    [TestClass]
    public class PlayersTests
    {
        private static IPlayerRepository _playerRepository;

        [TestMethod]
        public void CanCreatePlayer()
        {
            _playerRepository = new PlayerRepository();
            
            _playerRepository.AddNewPlayer("Pelle");


            List<Player> _players = _playerRepository.GetPlayers();


            Assert.AreEqual(_players[0].Name, "Pelle");

        }





    }
}
