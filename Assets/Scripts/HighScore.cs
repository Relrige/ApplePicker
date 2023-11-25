
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Напомню, эта библиотека нужна для работы с ТИП.
public class HighScore : MonoBehaviour
{
    static private Text _UI_TEXT;
    static public int score = 1000;
    void Awake()
    { 
        if (PlayerPrefs.HasKey("HighScore"))
        { 
            score = PlayerPrefs.GetInt("HighScore");
        }
         PlayerPrefs.SetInt("HighScore", score); // c
    }
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        if (score > PlayerPrefs.GetInt("HighScore"))
        { 
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}