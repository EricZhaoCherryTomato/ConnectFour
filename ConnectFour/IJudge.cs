namespace ConnectFour
{
    public interface IJudge
    {
        int CheckBoard(char[,] board, Player player);
    }
}