using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int PlayerLife;
    public int PlayerCoins;
    public static Action<int> OnLifeUpdate;
    public static Action<int> OnCoinUpdate;
    public static Action OnWin;
    public static Action OnLoose;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        PlayerCoins = 0;
        PlayerLife = 10;
    }
    public void GainCoin()
    {
        PlayerCoins += 50;
        OnCoinUpdate?.Invoke(PlayerCoins);
    }
    public void ModifyLife(int modify)
    {
        if(PlayerLife < 10)
        {
            PlayerLife += modify;
            OnLifeUpdate?.Invoke(PlayerLife);
        }
        else
        {
            PlayerLife = 10;
        }   
    }
    public void CheckWin()
    {
        Debug.Log("Ha ganado");
    }
    public void ValidateLife()
    {
        if(true ||  PlayerLife <= 0)
        {
            Debug.Log("Ha perdido");
        }
    }
}
