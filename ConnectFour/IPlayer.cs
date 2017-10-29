namespace ConnectFour
{
    public interface IPlayer
    {
        char GetPlayerColor();
        void SetPlayerColor(char color);
        string GetPlayerName();
        char[,] DropCoin(char[,] board, int dropchoice);
        void SetPlayerName(string name);
        Player Create();


    }
}