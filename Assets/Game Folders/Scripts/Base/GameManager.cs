using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameState currentState;
    [SerializeField] private Produk selectedProduk;

    public delegate void GameStateDelegate(GameState newState);
    public event GameStateDelegate OnStateChange;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeState(GameState state)
    {
        currentState = state;
        Debug.Log("CURRENT STATE : " + state);
        OnStateChange?.Invoke(state);
    }

    public void SetSelectedProduk(Produk newProduk)
    {
        selectedProduk = newProduk;
    }
}



public enum GameState
{
    Menu,
    Petunjuk,
    Profil,
    Level,
    SubProduk,
    AR,
    Pengaturan
}

public enum Produk
{
    Kursi,
    KursiKantor,
    Sofa,
    LemariPakaian,
    Kabinet,
    Rak
}
