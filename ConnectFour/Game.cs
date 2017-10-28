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
            int win=0;

            Console.Write(_board.PrintState(board));

            do
            {
                board = p1.DropCoin(board);
                Console.Write(_board.PrintCurrentState(board));
                //win = _judge.CheckBoard(board, (Player) p1);

                //if (win == 1)
                //{
                //    Console.WriteLine(p1.GetPlayerColor() + " Connected Four, You Win!");
                //}

                board = p2.DropCoin(board);
                Console.Write(_board.PrintCurrentState(board));
                //win = _judge.CheckBoard(board, (Player)p2);

                //if (win == 1)
                //{
                //    Console.WriteLine(p2.GetPlayerColor() + " Connected Four, You Win!");
                //}


                //Console.Write(_board.PrintState(board));
                
            } while (win!=1);

           

        }
    }
}