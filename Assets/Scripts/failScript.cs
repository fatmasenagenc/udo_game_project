using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failScript : MonoBehaviour
{
    [SerializeField] private TMP_Text gameScore;
    [SerializeField] private TMP_Text highScore;

    private void Awake()
    {
        gameScore.text = "+" + PlayerPrefs.GetInt("currentScore").ToString("0");
        Globals.speedMultiplier = 1.5f;
        Globals.timeOffset = 0.5f;

        if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore"))
        {
            highScore.text = "High Score: " + PlayerPrefs.GetInt("currentScore") + " (new!)";
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
        }
        else
        {
            highScore.text = "High Score: " + PlayerPrefs.GetInt("highScore");
        }
    }

    public void playAgain()
    {
        int temp = PlayerPrefs.GetInt("totalMoney") + PlayerPrefs.GetInt("currentScore");
        PlayerPrefs.SetInt("totalMoney", temp);
        SceneManager.LoadScene(1);
    }

    public void goToMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
