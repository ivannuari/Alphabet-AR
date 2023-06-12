using Ivannuari;
using UnityEngine;
using UnityEngine.UI;

public class MenuPage : Page
{
    [SerializeField] private Button b_level;
    [SerializeField] private Button b_petunjuk;

    private void Start()
    {
        b_level.onClick.AddListener(() => GameManager.Instance.ChangeState(GameState.Level));
        b_petunjuk.onClick.AddListener(() => GameManager.Instance.ChangeState(GameState.Petunjuk));
    }
}
