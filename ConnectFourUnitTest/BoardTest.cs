using System;
using ConnectFour;
using Moq;
using NUnit.Framework;

namespace ConnectFourUnitTest
{
    [TestFixture]
    public class BoardTest
    {
        [Test]
        public void BoardShouldPrintStartState()
        {
            Board board = new Board();
            char[,] state = new Char[8,8];
            var sut = board.PrintState(state);
            string expectedResult =
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r\n" +
                " 0 0 0 0 0 0 0 0\r";

            Assert.AreEqual(expectedResult, sut);

        }
    }

    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void Player_DropCoin_Should_Display_Correctly()
        {
            Player player = new Player();
            var state = new int[8, 8];

            var sut = player.DropCoin(state, "1");

            Assert.AreEqual(sut,state);
        }

    }
    
}