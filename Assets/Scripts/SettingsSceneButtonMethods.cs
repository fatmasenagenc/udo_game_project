using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSceneButtonMethods : MonoBehaviour
{
    public int MainSceneIndex;
    public void BackToMain()
    {
        SceneManager.LoadScene(MainSceneIndex);
    }
}
