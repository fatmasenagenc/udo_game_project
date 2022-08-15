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
        Debug.Log("pauseday�m");
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
        //globaldeki current score s�f�rla & ana men�ye d�n
        Debug.Log("quitteyim");
        Time.timeScale = 1;
        Globals.currentGameScore = 0;
        SceneManager.LoadScene(0);
    }
}
