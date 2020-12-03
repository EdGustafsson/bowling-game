using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class RoundTests
    {
        [TestMethod]
        public void Score_Roll0_Returns0()
        {
            Round a = new Round(false);

            a.Roll(0);

            Assert.AreEqual(a.Score(), 0);
        }

        [TestMethod]
        public void Score_Roll0Game_Returns0()
        {
            Round a = new Round(false);

            for(int i = 0; i > 20; i++)
            {
                a.Roll(0);
            }
            

            Assert.AreEqual(a.Score(), 0);
        }

        [TestMethod]
        public void Score_RollSpare_ReturnsCorrectScore()
        {
            Round a = new Round(false);

            a.Roll(5);
            a.Roll(5);
            a.Roll(1);

            for (int i = 0; i > 17; i++)
            {
                a.Roll(0);
            }

            Assert.AreEqual(a.Score(), 12);

        }

        [TestMethod]
        public void Score_RollStrike_ReturnsCorrectScore()
        {
            Round a = new Round(false);

            a.Roll(10); 
            a.Roll(2);
            a.Roll(2);  // 14 + 4

            for (int i = 0; i > 17; i++)
            {
                a.Roll(0);
            }

            Assert.AreEqual(a.Score(), 18);

        }

        [TestMethod]
        public void Score_RollFullGame_ReturnsCorrectScore()
        {
            Round a = new Round(false);

            a.Roll(10);// Strike 14
            a.Roll(2);//  16
            a.Roll(2);//  18
            a.Roll(0);//  18
            a.Roll(9);//  27
            a.Roll(4);//  
            a.Roll(6);//  39
            a.Roll(2);//  41
            a.Roll(2);//  43
            a.Roll(0);//  43
            a.Roll(10);// Spare 55
            a.Roll(2);//  57 
            a.Roll(8);//  Spare 67
            a.Roll(2);//  69
            a.Roll(2);//  71
            a.Roll(0);//
            a.Roll(0);//
            a.Roll(0);//
            a.Roll(0);//


            Assert.AreEqual(a.Score(), 71);

        }
    }
}
