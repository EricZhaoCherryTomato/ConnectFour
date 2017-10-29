using System;
using System.ComponentModel;
using System.Linq;

namespace ConnectFour
{
    public class Game :IGame
    {
        private readonly IBoard _board;
        private readonly IPlayer _player;
        private readonly IJudge _judge;
        public Game(IBoard board, IPlayer player, IJudge judge)
        {
            _board = board;
            _player = player;
            _judge = judge;
        }
        public void Start()
        {
            char[,] board = new char[5, 5];
            var p1 = _player.Create();
            p1.SetPlayerColor('y');
            var p2 = _player.Create();
            p2.SetPlayerColor('r');

            Console.Write(_board.PrintState(board));

            do
            {
                Console.Write("\n");
                Console.WriteLine("Yellows Turn ");
                int dropChoice = Convert.ToInt32(Console.ReadLine());
                board = p1.DropCoin(board, dropChoice-1);
                Console.Write(_board.PrintState(board));
                var win = _judge.CheckBoard(board, (Player) p1);

                if (win)
                {
                    Console.WriteLine("Yellow WINS !");
                    break;
                }
                Console.Write("\n");
                Console.WriteLine("Reds Turn ");
                dropChoice = Convert.ToInt32(Console.ReadLine());
                board = p2.DropCoin(board, dropChoice-1);
                Console.Write(_board.PrintState(board));
                win = _judge.CheckBoard(board, (Player)p2);

                if (win)
                {
                    Console.WriteLine("Reds WINS!");
                    break;
                }

            } while (true);

            Console.ReadKey(true);

        }
    }
}