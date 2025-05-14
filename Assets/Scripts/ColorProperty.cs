using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    public string materialname;
    [SerializeField] protected ColorData colorData;
    [SerializeField] protected MeshRenderer meshRenderer;
    protected Material material;
    private void Start()
    {

        material = meshRenderer.material;

        SetUpColor(colorData);
    }
    protected void SetUpColor(ColorData newColor)
    {
        colorData = newColor;
        material.SetColor(materialname, colorData.color);
    }
}
