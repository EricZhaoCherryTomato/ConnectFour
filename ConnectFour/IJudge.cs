namespace ConnectFour
{
    public interface IJudge
    {
        bool CheckBoard(char[,] board, Player player);
    }
}