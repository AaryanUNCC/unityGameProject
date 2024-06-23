using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 100;
    public float damage = 10;
    Image healthImage;
    void Start()
    {
        healthImage = GetComponent<Image>();
        SetHealthBar();
    }

    public void TakeDamage()
    {
        health -= damage;
        SetHealthBar();
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void SetHealthBar()
    {
        healthImage.fillAmount = health/100.0f;
    }
}
