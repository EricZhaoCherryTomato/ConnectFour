using ConnectFour;
using NUnit.Framework;

namespace ConnectFourUnitTest
{
    [TestFixture]
    public class JudgeTest
    {
        [Test]
        public void Judge_Horizontal_Yellow_Wins ()
        {
            Player player = new Player {PlayerColor = 'y'};
            Judge judge = new Judge();

            var board = new char[8, 8];
            
            for (int j = 0; j < 5; j++)
            {
                board[0, j] = 'y';
            }
            
            var sut = judge.CheckBoard(board,player);

            Assert.AreEqual(true, sut);
        }

        [Test] public void Judge_Horizontal_Red_Vertical_Wins ()
        {
            Player player = new Player {PlayerColor = 'r'};
            Judge judge = new Judge();

            var board = new char[8, 8];
            
            for (int j = 0; j < 5; j++)
            {
                board[j, 0] = 'r';
            }
            
            var sut = judge.CheckBoard(board,player);

            Assert.AreEqual(true, sut);
        }

        [Test]
        public void Judge_Diagonal_Yellow_Wins ()
        {
            Player player = new Player {PlayerColor = 'y'};
            Judge judge = new Judge();

            var board = new char[8, 8];

            for (int j = 0; j < 5; j++)
            {
                board[j, j] = 'y';
            }

            var sut = judge.CheckBoard(board,player);

            Assert.AreEqual(true, sut);
        }
        [Test]
        public void Judge_Draw ()
        {
            Player player = new Player {PlayerColor = 'y'};
            Judge judge = new Judge();

            var board = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j = j+2)
                {
                    board[i, j] = 'y';
                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j = j+2)
                {
                    board[i, j] = 'y';
                }

            }
            for (int i = 0; i < 5; i = i+2)
            {
                for (int j = 0; j < 5; j =j+2)
                {
                    board[i, j] = 'r';
                }

            }
            for (int i = 1; i < 5; i = i +2)
            {
                for (int j = 1; j < 5; j = j+2)
                {
                    board[i, j] = 'r';
                }

            }
            board[1, 1] = 'y';
            board[1, 3] = 'y';
            board[1, 2] = 'r';
            board[1, 4] = 'r';
            var t = new Board().PrintState(board);
            var sut = judge.CheckBoard(board,player);

            Assert.AreEqual(false, sut);
        }

    }
}