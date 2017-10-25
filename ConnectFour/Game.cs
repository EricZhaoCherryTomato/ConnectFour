using System;

namespace ConnectFour
{
    public class Game :IGame
    {
        private readonly IBoard _board;
        public Game(IBoard board)
        {
            _board = board;
        }
        public void Start()
        {
            Console.Write(_board.PrintState());
        }
    }
}