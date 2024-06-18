using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnStartGame()
    {
        Debug.Log("OnStartButton Clicked");
        SceneManager.LoadScene("Level1");
    }
}
