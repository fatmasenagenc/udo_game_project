using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class touch : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField] private Material material;

    private int score = 0;
    [SerializeField] private TMP_Text scoreText;
    private bool entered;
    private GameObject collided;

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
            Destroy(collider.gameObject);
        }
    }

    public void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.shader = shader;
        if (entered)
        {
            Debug.Log("caught - " + name);
            score = int.Parse(scoreText.text) + 10;
            scoreText.text = score.ToString("0");
            Destroy(collided);
            entered = false;
        }
    }

    public void OnMouseUp()
    {
        GetComponent<MeshRenderer>().material = material;
    }
}
