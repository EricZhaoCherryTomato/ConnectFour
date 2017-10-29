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
        public void Board_Should_Print_Start_State()
        {
            Board board = new Board();
            char[,] state = new Char[8,8];
            var sut = board.PrintState(state);

            string expectedResult = " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r";

            Assert.AreEqual(sut, expectedResult);

        }

        [Test]
        public void Board_Should_Print_Current_State()
        {
            Board board = new Board();
            char[,] state = new Char[8,8];
            state[7, 0] = 'r';
            var sut = board.PrintState(state);

            string expectedResult = " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " o o o o o o o o\r\n" +
                                    " r o o o o o o o\r";

            Assert.AreEqual(sut, expectedResult);

        }
    }
}