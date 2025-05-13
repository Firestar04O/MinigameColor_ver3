using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Image ColorImage;
    private void UpdateColor(Color newColor)
    {
        ColorImage.color = newColor;
    }
    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
    }
    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
    }
}