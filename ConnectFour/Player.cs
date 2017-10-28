using System;

namespace ConnectFour
{
    public class Player : IPlayer
    {
        public char PlayerColor { get; set; }


        public char GetPlayerColor()
        {
            return PlayerColor;
        }

        public void SetPlayerColor(char color)
        {
            PlayerColor = color;
        }

        public char[,] DropCoin(char[,] board)
        {
            int dropChoice;
            Console.Write("\n");
            Console.WriteLine(this.PlayerColor + "'s Turn ");
            do
            {
                Console.WriteLine("Please enter a number between 1 and 7: ");
                dropChoice = Convert.ToInt32(Console.ReadLine());
                dropChoice--;
            } while (dropChoice < 0 || dropChoice > board.GetLength(1));

            while (board[0, dropChoice] == 'y' || board[0, dropChoice] == 'r')
            {
                Console.WriteLine("That row is full, please enter a new row: ");
                dropChoice = Convert.ToInt32(Console.ReadLine());
            }

            int length, turn;
            length = board.GetLength(1)-1;
            turn = 0;

            do
            {
                if (board[length, dropChoice] != 'y' && board[length, dropChoice] != 'r')
                {
                    board[length, dropChoice] = this.PlayerColor;
                    turn = 1;
                }
                else
                    --length;
            } while (turn != 1);
            //board[7, dropChoice] = this.PlayerColor;
            return board;
        }

        public Player Create()
        {
            return new Player();
        }

    }
}