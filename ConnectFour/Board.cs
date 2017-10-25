using System;
using System.Text;

namespace ConnectFour
{
    public class Board : IBoard
    {
        private  int[,] state = new int[8,8];
        private int size = 8;

        public string PrintState()
        {
            var builder = new StringBuilder();

            for (int row = 0; row < 8; row++)
            {
                string str = "";
                for (int col = 0; col < 8; col++)
                {
                    str += " " + state[row, col];
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