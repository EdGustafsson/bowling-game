using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class RoundTests
    {
        [TestMethod]
        public void CanRollGutter()
        {
            Round a = new Round();

            a.Roll(0);

            Assert.AreEqual(a.Score(), 0);
        }

        [TestMethod]
        public void CanRollGutterGame()
        {
            Round a = new Round();

            for(int i = 0; i > 20; i++)
            {
                a.Roll(0);
            }
            

            Assert.AreEqual(a.Score(), 0);
        }
    }
}
