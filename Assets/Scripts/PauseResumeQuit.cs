using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeQuit : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject halfFull;
    [SerializeField] private GameObject full;

    //private bool paused;

    //private void Start()
    //{
    //    FillGlass();
    //}

    //private void FillGlass()
    //{
    //    StartCoroutine(fill());

    //    IEnumerator fill()
    //    {

    //        while (!Globals.failed && !paused)
    //        {
    //            if (!Globals.failed && !paused)
    //            {
    //                yield return new WaitForSecondsRealtime(1);
    //                halfFull.SetActive(true);
    //            }
    //            else if (paused)
    //            {
    //                yield break;
    //            }
    //            else if (Globals.failed)
    //            {
    //                Empty();
    //                yield break;
    //            }

    //            if (!Globals.failed && !paused)
    //            {
    //                yield return new WaitForSecondsRealtime(1);
    //                full.SetActive(true);
    //            }
    //            else if (paused)
    //            {
    //                yield break;
    //            }
    //            else if (Globals.failed)
    //            {
    //                Empty();
    //                yield break;
    //            }
                

    //            if (!Globals.failed && !paused)
    //            {
    //                yield return new WaitForSecondsRealtime(0.6f);
    //                Empty();
    //            }
    //            else if (paused)
    //            {
    //                yield break;
    //            }
    //            else if (Globals.failed)
    //            {
    //                Empty();
    //                yield break;
    //            }
                
    //        }
    //    }
    //}

    //private void Empty()
    //{
    //    halfFull.SetActive(false);
    //    full.SetActive(false);
    //}
    public void Pause()
    {
        panel.SetActive(true);
        //paused = true;
        Time.timeScale = 0;
    }
    public void KeepPlaying()
    {
        panel.SetActive(false);
        //paused = false;
        Time.timeScale = 1;
        //FillGlass();
    }

    public void Quit()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("currentScore", 0);
        SceneManager.LoadScene(0);
    }
}
