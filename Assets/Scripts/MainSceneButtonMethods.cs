using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButtonMethods : MonoBehaviour
{
    /*public int GamingSceneIndex;
    public int MoneySceneIndex = 2;
    public int MarketIndex = 3;
    public int SettingsIndex = 4;*/
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMoneyScene()
    {
        //Debug.Log(MoneySceneIndex);
        SceneManager.LoadScene(2);
    }

    public void ToMarket()
    {
        //Debug.Log(MarketIndex);
        SceneManager.LoadScene(3);
    }

    public void ToSettings()
    {
        //Debug.Log(SettingsIndex);
        SceneManager.LoadScene(4);
    }
}
