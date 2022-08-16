using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static float speedMultiplier = 1.5f;
    public static float timeOffset = 0.5f;
    public static int currentGameScore = 0;
    public static bool failed = false;
}

public class cubeMovement : MonoBehaviour
{
    //private float speedMultiplier;
    private float gradualIncrease = 5f;
    //private bool speedIncreased;
    //private int count;
    //[SerializeField] private Material material;

    //private void Start()
    //{
    //    speedMultiplier = 
    //}

    void Awake()
    {
        Globals.speedMultiplier += speedIncrease();
        Debug.Log("speedMultiplier is " + Globals.speedMultiplier);
        Debug.Log("timeoffset is " + Globals.timeOffset);

        if (Globals.speedMultiplier >= 10f)
        {
            Globals.timeOffset = 0.1f;
        }
        else if (Globals.speedMultiplier >= 5f)
        {
            Globals.timeOffset = 0.3f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //speedMultiplier = Random.Range(3f, 15f);
        transform.Translate(Vector3.back * Time.deltaTime * Globals.speedMultiplier);
        //Debug.Log("next speed for " + name + " -- " + Globals.speedMultiplier);

        //if (transform.position.z <= -46f)
        //{
        //    GetComponent<MeshRenderer>().material = material;
        //}
        //if (speedIncreased == false)
        //{
        //    speedMultiplier += gradualIncrease;
        //    speedIncreased = true;
        //    count++;
        //    Debug.Log("next speed for " + name + " -- " + speedMultiplier);

        //    if (count == 3)
        //    {
        //        speedIncreased = false;
        //        count = 0;
        //    }
        //}
    }

    float speedIncrease()
    {
        return gradualIncrease * Time.deltaTime;
    }
}
