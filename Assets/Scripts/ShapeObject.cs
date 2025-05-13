using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;
    public static Action<Sprite> OnChangeShape;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        shapeData.sprite = spriteRenderer.sprite;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}
