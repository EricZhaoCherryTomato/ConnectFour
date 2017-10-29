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

        public char[,] DropCoin(char[,] board, int dropChoice)
        {
            
            //do
            //{
            //    Console.WriteLine("Please enter a number between 1 and 7: ");
            //    //dropChoice = Convert.ToInt32(Console.ReadLine());
            //    dropChoice--;
            //} while (dropChoice < 0 || dropChoice > board.GetLength(1));

            //while (board[0, dropChoice] == 'y' || board[0, dropChoice] == 'r')
            //{
            //    Console.WriteLine("That row is full, please enter a new row: ");
            //    dropChoice = Convert.ToInt32(Console.ReadLine());
            //}
            

            for (int row = board.GetLength(0)-1; row > 0; row--)
            {
                if (board[row, dropChoice] == 'o')
                {
                    board[row, dropChoice] = this.PlayerColor;
                    break;
                }
            }

            return board;
        }

        public Player Create()
        {
            return new Player();
        }

    }
}