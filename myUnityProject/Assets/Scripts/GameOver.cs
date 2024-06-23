using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gemUi;
    public void Start()
    {
        int gems = PlayerPrefs.GetInt("Gems");
        gemUi.text = "Gem Collected: " + gems;
    }
    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
