using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;
    public static Action<Color> OnChangeColor;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorData.color = spriteRenderer.color;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
