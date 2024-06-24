using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text GemUi;
    public void Start()
    {
        int gems = PlayerPrefs.GetInt("Gems");
        Debug.Log("Gems = " + gems);
        GemUi.text = "Gem Collected: " + gems;
    }
    public void OnStartGame()
    {
        int currentLevel = 1;
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        Debug.Log("OnStartButton Clicked");
        SceneManager.LoadScene("Level" + currentLevel);
    }
}
