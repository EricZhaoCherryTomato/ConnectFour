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

            var sut = board.PrintState();
            string expectedResult =
                " 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r\n 0 0 0 0 0 0 0 0\r";

            Assert.AreEqual(expectedResult, sut);

        }
    }
}