using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPage : Page
{
    [SerializeField] private Button b_home;
    [SerializeField] private Button[] allLevels;

    private void Start()
    {
        b_home.onClick.AddListener(() => GameManager.Instance.ChangeState(GameState.Menu));

        foreach (var item in allLevels)
        {
            item.onClick.AddListener(() => ChangeScene("AR Scene"));
        }
    }
}
