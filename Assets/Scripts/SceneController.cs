using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string SceneryToGo;
    public void GameExit()
    {
        Debug.Log("Ha salido del programa");
        Application.Quit();
    }
    public void ChangeScenery()
    {
        SceneManager.LoadScene(SceneryToGo);
    }
}
