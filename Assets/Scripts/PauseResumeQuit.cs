using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeQuit : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject halfFull;
    [SerializeField] private GameObject full;
    private float deltaTimeHolder;

    private void Start()
    {
        FillGlass();
    }
    private void FillGlass()
    {
        StartCoroutine(fill());

        IEnumerator fill()
        {
            //if (Globals.failed)
            //{
            //    yield break;
            //}

            while (!Globals.failed)
            {
                if (!Globals.failed)
                {
                    yield return new WaitForSecondsRealtime(1); //animasyon s?resini giricez, ya da biraz fazla garanti olur
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
        //deltaTimeHolder = Time.deltaTime;
        //Invoke("GlassHalfFill", deltaTimeHolder + 1f);
        //Invoke("GlassFill", deltaTimeHolder + 2f);
        //Invoke("Empty", deltaTimeHolder + 2.6f);
    }
    private void GlassHalfFill()
    {
        halfFull.SetActive(true);
    }

    private void GlassFill()
    {
        full.SetActive(true);
    } 

    private void Empty()
    {
        halfFull.SetActive(false);
        full.SetActive(false);
    }
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
