using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public delegate void GameManagerEventHandler();
    public event GameManagerEventHandler GameOverEvent;
    public event GameManagerEventHandler WinningEvent;

    public bool isGameOver;
    public bool isWin;

    public void CallEventGameOver()
    {
        if(GameOverEvent != null)
        {
            isGameOver = true;
            GameOverEvent();
        }
    }

    public void CallEventWinning()
    {
        if(WinningEvent != null)
        {
            isWin = true;
            WinningEvent();
        }
    }
}
