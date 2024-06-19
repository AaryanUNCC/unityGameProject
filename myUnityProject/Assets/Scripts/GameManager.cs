using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int gemCollected;
    public Text gemUI;
    public void OnGemCollected()
    {
        gemCollected++;
        gemUI.text = "Gem: " + gemCollected;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Gems", gemCollected);
    }
}
