using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Slate;

public class touch : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField] private Material material;
    [SerializeField] private GameObject disablePlane;
    [SerializeField] private GameObject pauseButton;

    [SerializeField] private TMP_Text scoreText;
   
    [SerializeField] private Cutscene failScene;
    [SerializeField] private Cutscene fillScene;

    [SerializeField] private ParticleSystem ps;

    private bool entered;
    private GameObject collided;

    private void Start()
    {
        PlayerPrefs.SetInt("currentScore", 0);
    }

    public void OnTriggerEnter(Collider collider)
    {
        entered = true;
        collided = collider.gameObject;
    }

    public void OnTriggerExit(Collider collider)
    {
        entered = false;
        if (collider.gameObject.CompareTag("cubes"))
        {
            GetComponent<Rigidbody>().isKinematic = false;

            Globals.failed = true;

            disablePlane.SetActive(true);
            fillScene.Stop();
            failScene.Play();
            pauseButton.SetActive(false);
            Invoke("EndGame", 4.5f);
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
            ps.Play();

            int temp = PlayerPrefs.GetInt("currentScore") + 5;
            PlayerPrefs.SetInt("currentScore", temp);
            scoreText.text = PlayerPrefs.GetInt("currentScore").ToString("0");
            Destroy(collided);
            entered = false;
        }
    }

    public void OnMouseUp()
    {
        GetComponent<MeshRenderer>().material = material;
    }
}
