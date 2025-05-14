using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Vector3 AngleRotations;
    private void QuaternionRotation()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GainCoin();
            Destroy(gameObject);
        }
    }
}