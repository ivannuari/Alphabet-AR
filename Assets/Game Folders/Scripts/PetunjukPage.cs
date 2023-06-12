using Ivannuari;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetunjukPage : Page
{
    [SerializeField] private Button b_home;

    private void Start()
    {
        b_home.onClick.AddListener(() => GameManager.Instance.ChangeState(GameState.Menu));
    }
}
