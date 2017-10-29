using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Judge : IJudge
    {
        public bool CheckBoard(char[,] board, Player player)
        {
            
            char playerColor = player.PlayerColor;
            var win = false;

            for (int row = board.GetLength(0)-1; row >= 0; row--)
            {

                for (int col = board.GetLength(1)-1; col >= 0; col--)
                {

                    if (col - 3 > 0 && row -3 > 0 && board[row, col] == playerColor &&
                        board[row - 1, col - 1] == playerColor &&
                        board[row - 2, col - 2] == playerColor &&
                        board[row - 3, col - 3] == playerColor)
                    {
                        win = true;
                        break;
                    }



                    if (col - 3 > 0 && board[row, col] == playerColor &&
                        board[row, col - 1] == playerColor &&
                        board[row, col - 2] == playerColor &&
                        board[row, col - 3] == playerColor)
                    {
                        win = true;
                        break;
                    }

                    if (row - 3 > 0 && board[row, col] == playerColor &&
                        board[row - 1, col] == playerColor &&
                        board[row - 2, col] == playerColor &&
                        board[row - 3, col] == playerColor)
                    {
                        win = true;
                        break;
                    }



                    if (col + 3 < board.GetLength(1) && row - 3 > 0 && board[row, col] == playerColor &&
                        board[row - 1, col + 1] == playerColor &&
                        board[row - 2, col + 2] == playerColor &&
                        board[row - 3, col + 3] == playerColor)
                    {
                        win = true;
                        break;
                    }

                    if (col + 3 < board.GetLength(1) && board[row, col] == playerColor &&
                        board[row, col + 1] == playerColor &&
                        board[row, col + 2] == playerColor &&
                        board[row, col + 3] == playerColor)
                    {
                        win = true;
                        break;
                    }
                }

            }

            return win;
        }
    }
}
