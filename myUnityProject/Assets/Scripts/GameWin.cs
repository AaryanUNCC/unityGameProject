using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWin : MonoBehaviour
{
    public TextMeshProUGUI gemUi;
    private int currentLevel;
    public TextMeshProUGUI titleUI;
    public Button NextButton;
    public void Start()
    {
        currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        int gems = PlayerPrefs.GetInt("Gems");
        gemUi.text = "Gem Collected: " + gems;
        if (currentLevel == 3)
        {
            titleUI.text = "Horray! You have completed all levels";
            NextButton.interactable = false;
        }
    }
    public void Next()
    {
        currentLevel += 1;
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        SceneManager.LoadScene("Level" + currentLevel);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
