using System;
using System.Text;

namespace ConnectFour
{
    public class Board : IBoard
    {

        public string PrintState(char[,] board)
        {
            var builder = new StringBuilder();

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string str = "";
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] != 'y' && board[row, col] != 'r')
                        board[row, col] = 'o';
                    str += " " + board[row, col];
                }
                builder.Append(str);
                builder.AppendLine();
            }

            return builder.ToString(0, builder.Length - 1);
        }

        public string PrintCurrentState(char[,] board)
        {
            var builder = new StringBuilder();

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string str = "";
                for (int col = 0; col < board.GetLength(1); col++)
                {
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