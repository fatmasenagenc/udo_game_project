using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButtonMethods : MonoBehaviour
{
    [SerializeField] private TMP_Text money;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();

        if (!PlayerPrefs.HasKey("highScore"))
        {
            PlayerPrefs.SetInt("highScore", 0);
        }

        if (!PlayerPrefs.HasKey("totalMoney"))
        {
            PlayerPrefs.SetInt("totalMoney", 0);

        }
        else
        {
            int temp = PlayerPrefs.GetInt("totalMoney") + PlayerPrefs.GetInt("currentScore");
            PlayerPrefs.SetInt("totalMoney", temp);
        }

        money.text = PlayerPrefs.GetInt("totalMoney").ToString("0");
        PlayerPrefs.SetInt("currentScore", 0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMoneyScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ToMarket()
    {
        SceneManager.LoadScene(3);
    }

    public void ToSettings()
    {
        SceneManager.LoadScene(4);
    }
}

