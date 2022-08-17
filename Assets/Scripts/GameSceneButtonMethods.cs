using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtonMethods : MonoBehaviour
{
   public GameObject exitPanel;

    public int MainSceneIndex;
   public void PauseGame()
   {
        exitPanel.SetActive(true);
   }

    public void exitGame()
    {
        SceneManager.LoadScene(MainSceneIndex);
    }

    public void continueGame()
    {
        SceneManager.GetActiveScene();
        exitPanel.SetActive(false);
    }
}
