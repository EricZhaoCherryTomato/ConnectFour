using System;
using System.Collections;
using System.Collections.Generic;
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
            var boardDimension = _board.InitBoard();
            char[,] board = new char[boardDimension[0], boardDimension[1]];;
            var p1 = _player.Create();
            p1.SetPlayerColor('y');
            p1.SetPlayerName("Yellows");
            
            var p2 = _player.Create();
            p2.SetPlayerColor('r');
            p2.SetPlayerName("Reds");

            Console.Write(_board.PrintState(board));

            do
            {
                if (GetMove(p1, board)) break;
                if (GetMove(p2, board)) break;
                
            } while (true);

            Console.ReadKey(true);

        }

        

        private bool GetMove(Player player,  char[,] board)
        {
            var dropChoice = -1;
            do
            {
                try
                {
                    Console.Write("\n");
                    Console.WriteLine(player.PlayerName + " Turn ");
                    dropChoice = Convert.ToInt32(Console.ReadLine());
                    board = player.DropCoin(board, dropChoice - 1);
                    Console.Write(_board.PrintState(board));
                    var win = _judge.CheckBoard(board, player);

                    if (!win) return false;
                    Console.Write("\n");
                    Console.WriteLine(player.PlayerName + " WINS !");
                }
                catch
                {
                    Console.Write("Invalid Move");
                }
            } while (dropChoice < 0);
            
            return true;
        }
    }
}