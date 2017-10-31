namespace ConnectFour
{
    public interface IBoard
    {
        string PrintState(char[,] board);
        string PrintCurrentState(char[,] board);
        int[] InitBoard();
    }
}