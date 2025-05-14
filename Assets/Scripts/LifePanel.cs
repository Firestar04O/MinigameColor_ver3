using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifePanel : MonoBehaviour
{
    public TextMeshProUGUI _Texthealth;
    private void OnEnable()
    {
        GameManager.OnLifeUpdate += OnLifeUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnLifeUpdate -= OnLifeUpdate;
    }
    public void OnLifeUpdate(int life)
    {
        _Texthealth.text = life.ToString();
    }
}
