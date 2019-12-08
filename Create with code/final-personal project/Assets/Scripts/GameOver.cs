using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Gamemanager gameManagerMaster;
    public GameObject panelGameOver;
    private void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.GameOverEvent += turnOnGameOverPanel;
    }

    private void OnDisable()
    {
        gameManagerMaster.GameOverEvent -= turnOnGameOverPanel;
    }

    private void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<Gamemanager>();
    }

    void turnOnGameOverPanel()
    {
        if(panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }
    }
}
