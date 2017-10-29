using ConnectFour;
using NUnit.Framework;

namespace ConnectFourUnitTest
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void Player_DropCoin_Should_Put_Coin_Correctly()
        {
            Player player = new Player {PlayerColor = 'r'};
            var board = new char[8, 8];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 'o';
                }
            }

            var sut = player.DropCoin(board, 0);

            Assert.AreEqual('r', sut[7, 0]);
        }

    }
}