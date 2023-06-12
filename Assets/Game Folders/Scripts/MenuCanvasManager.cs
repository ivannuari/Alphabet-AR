using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvasManager : CanvasManager
{
    private void Start()
    {
        GameManager.Instance.OnStateChange += Instance_OnStateChange;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnStateChange -= Instance_OnStateChange;
    }

    private void Instance_OnStateChange(GameState newState)
    {
        switch (newState)
        {
            case GameState.Menu:
                SetPage(PageName.Menu);
                break;
            case GameState.Petunjuk:
                SetPage(PageName.Petunjuk);
                break;
            case GameState.Profil:
                SetPage(PageName.Profil);
                break;
            case GameState.Level:
                SetPage(PageName.Level);
                break;
            case GameState.SubProduk:
                break;
            case GameState.AR:
                break;
            case GameState.Pengaturan:
                break;
        }
    }
}
