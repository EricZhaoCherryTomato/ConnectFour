﻿namespace ConnectFour
{
    public interface IPlayer
    {
        char GetPlayerColor();
        void SetPlayerColor(char color);
        char[,] DropCoin(char[,] board);
        Player Create();


    }
}