using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeQuit : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject halfFull;
    [SerializeField] private GameObject full;

    private void Start()
    {
        FillGlass();
    }

    private void FillGlass()
    {
        StartCoroutine(fill());

        IEnumerator fill()
        {

            while (!Globals.failed)
            {
                if (!Globals.failed)
                {
                    yield return new WaitForSecondsRealtime(1);
                    halfFull.SetActive(true);
                } else
                {
                    Empty();
                    yield break;
                }

                if (!Globals.failed)
                {
                    yield return new WaitForSecondsRealtime(1);
                    full.SetActive(true);
                }
                else
                {
                    Empty();
                    yield break;
                }

                if (!Globals.failed)
                {
                    yield return new WaitForSecondsRealtime(0.6f);
                    Empty();
                }
                else
                {
                    Empty();
                    yield break;
                }
            }
        }
    }

    private void Empty()
    {
        halfFull.SetActive(false);
        full.SetActive(false);
    }
    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void KeepPlaying()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("currentScore", 0);
        SceneManager.LoadScene(0);
    }
}
