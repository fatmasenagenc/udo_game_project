using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Slate;

//public static class TransferData
//{
//    public static int currentGameScore = 0;
//}

public class touch : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField] private Material material;

    [SerializeField] private TMP_Text scoreText;
    private bool entered;
    private GameObject collided;
    [SerializeField] private Cutscene failScene;
    [SerializeField] private Cutscene fillScene;

    public void OnTriggerEnter(Collider collider)
    {
        entered = true;
        collided = collider.gameObject;
        if (collider.gameObject.tag == "cubes")
        {
            Debug.Log("collision with " + collider.gameObject.name + "by " + name);
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        entered = false;
        if (collider.gameObject.CompareTag("cubes"))
        {
            Debug.Log("missed - " + name);
            //Destroy(collider.gameObject);
            Debug.Log("global current score will be " + Globals.currentGameScore);
            //Globals.currentGameScore = score;
            Debug.Log("global current score set to " + Globals.currentGameScore);
            Globals.failed = true;
            int temp = PlayerPrefs.GetInt("totalMoney") + Globals.currentGameScore;
            PlayerPrefs.SetInt("totalMoney", temp);
            fillScene.Stop();
            failScene.Play();
            
            Invoke("EndGame", 5);

            //StartCoroutine(LoadFailScreen());

            //IEnumerator LoadFailScreen()
            //{
            //    Time.timeScale = 0;
            //    yield return new WaitForSecondsRealtime(6); //animasyon s�resini giricez, ya da biraz fazla garanti olur
            //    Time.timeScale = 1;
            //    Globals.failed = false;
            //    EndGame();
            //}
        }
    }

    public void EndGame()
    {
        Globals.failed = false;
        SceneManager.LoadScene(5);
    }

    public void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.shader = shader;
        if (entered)
        {
            Debug.Log("caught - " + name);
            Globals.currentGameScore = int.Parse(scoreText.text) + 5;
            scoreText.text = Globals.currentGameScore.ToString("0");
            Destroy(collided);
            entered = false;
        }
    }

    public void OnMouseUp()
    {
        GetComponent<MeshRenderer>().material = material;
    }
}
