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
            p1.SetPlayerName("Yellows");
            
            var p2 = _player.Create();
            p2.SetPlayerColor('r');
            p2.SetPlayerName("Reds");

            Console.Write(_board.PrintState(board));

            do
            {
                if (GetValue(p1, board)) break;
                if (GetValue(p2, board)) break;
                
            } while (true);

            Console.ReadKey(true);

        }

        private bool GetValue(Player player,  char[,] board)
        {
            Console.Write("\n");
            Console.WriteLine(player.PlayerName + " Turn ");
            var dropChoice = Convert.ToInt32(Console.ReadLine());
            board = player.DropCoin(board, dropChoice - 1);
            Console.Write(_board.PrintState(board));
            var win = _judge.CheckBoard(board, player);

            if (!win) return false;
            Console.Write("\n");
            Console.WriteLine(player.PlayerName + " WINS !");
            return true;
        }
    }
}