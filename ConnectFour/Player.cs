namespace ConnectFour
{
    public class Player : IPlayer
    {
        public char PlayerColor { get; set; }
        public string PlayerName { get; set; }


        public char GetPlayerColor()
        {
            return PlayerColor;
        }

        public void SetPlayerColor(char color)
        {
            PlayerColor = color;
        }

        public string GetPlayerName()
        {
            return PlayerName;
        }

        public char[,] DropCoin(char[,] board, int dropChoice)
        {
            for (var row = board.GetLength(0) - 1; row > 0; row--)
                if (board[row, dropChoice] == 'o')
                {
                    board[row, dropChoice] = PlayerColor;
                    break;
                }

            return board;
        }

        public void SetPlayerName(string name)
        {
            PlayerName = name;
        }

        public Player Create()
        {
            return new Player();
        }
    }
}