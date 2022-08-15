using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeQuit : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void Pause()
    {
        //burada sahneyi durdur
        Debug.Log("pausedayým");
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void KeepPlaying()
    {
        //sahneyi devam ettir
        Debug.Log("keep playdeyim");
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        //globaldeki current score sýfýrla & ana menüye dön
        Debug.Log("quitteyim");
        Time.timeScale = 1;
        Globals.currentGameScore = 0;
        SceneManager.LoadScene(0);
    }
}
