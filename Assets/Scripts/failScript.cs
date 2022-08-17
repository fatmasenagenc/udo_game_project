using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failScript : MonoBehaviour
{
    [SerializeField] private TMP_Text gameScore;

    private void Awake()
    {
        gameScore.text = "+" + PlayerPrefs.GetInt("currentScore").ToString("0");
        Globals.speedMultiplier = 1.5f;
        Globals.timeOffset = 0.5f;
}

    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void goToMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
