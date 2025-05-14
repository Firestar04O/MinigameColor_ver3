using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinPanel : MonoBehaviour
{
    public TextMeshProUGUI _Textcoins;
    private void OnEnable()
    {
        GameManager.OnCoinUpdate += OnCoinUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnCoinUpdate -= OnCoinUpdate;
    }
    public void OnCoinUpdate(int coins)
    {
        _Textcoins.text = coins.ToString();
    }
}
