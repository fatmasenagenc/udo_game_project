using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//public static class TransferData
//{
//    public static int currentGameScore = 0;
//}

public class touch : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField] private Material material;

    //private int score = 0;
    [SerializeField] private TMP_Text scoreText;
    private bool entered;
    private GameObject collided;

    //private bool failed = false;

    //void Update()
    //{
    //    if (failed) {
    //        Invoke("EndGame", 3f);
    //    }
    //}
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
            //failed = true;
            //Time.timeScale = 0;
            EndGame();
        }
    }

    public void EndGame()
    {
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
