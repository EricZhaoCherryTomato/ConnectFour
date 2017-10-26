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
            } while (dropChoice < 1 || dropChoice > 7);

            while (board[1, dropChoice] == 'Y' || board[1, dropChoice] == 'R')
            {
                Console.WriteLine("That row is full, please enter a new row: ");
                dropChoice = Convert.ToInt32(Console.ReadLine());
            }
            board[7, dropChoice] = this.PlayerColor;
            return board;
        }

    }
}