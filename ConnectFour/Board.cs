using System;
using System.Text;

namespace ConnectFour
{
    public class Board : IBoard
    {
        //private  int[,] board = new int[8,8];
        private int size = 8;

        public string PrintState(char[,] board)
        {
            var builder = new StringBuilder();

            for (int row = 0; row < 8; row++)
            {
                string str = "";
                for (int col = 0; col < 8; col++)
                {
                    if (board[row, col] != 'Y' && board[row, col] != 'R')
                        board[row, col] = '*';
                    str += " " + board[row, col];
                }
                builder.Append(str);
                builder.AppendLine();
            }

            return builder.ToString(0, builder.Length - 1);
        }

        public void Reset()
        {
        }
    }
}