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

            if (SomeoneWins(board))
            {
                return true;
            }
            return false;
            
        }

        public static bool AllFieldsTheSame(int startX, int startY, char[,] board, int dx, int dy)
        {
            int firstField = board[startY, startX];
            if (firstField == 0)
            {
                return false;
            }

            for (var i = 0; i < 4; i++)
            {
                int y = startY + dy * i;
                int x = startX + dx * i;
                if (board[y, x] != firstField)
                {
                    return false;
                }
            }

            return true;
        }

        public bool SomeoneWins(char[,] board)
        {
            // Check columns
            for (var x = 0; x < board.GetLength(0); x++)
            {
                if (AllFieldsTheSame(x, 0, board, 0, 1))
                    return true;
            }

            // Check rows
            for (var y = 0; y < board.GetLength(1); y++)
                if (AllFieldsTheSame(0, y, board, 1, 0))
                    return true;

            // Check diagonals
            if (AllFieldsTheSame(0, 0, board, 1, 1))
                return true;

            if (AllFieldsTheSame(2, 0, board, -1, 1))
                return true;

            return false;
        }
    }
}
