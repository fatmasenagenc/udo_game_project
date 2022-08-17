using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static float speedMultiplier = 1.5f;
    public static float timeOffset = 0.5f;
    public static bool failed = false;
}

public class cubeMovement : MonoBehaviour
{
    private float gradualIncrease = 5f;

    void Awake()
    {
        Globals.speedMultiplier += speedIncrease();

        if (Globals.speedMultiplier >= 10f)
        {
            Globals.timeOffset = 0.1f;
        }
        else if (Globals.speedMultiplier >= 5f)
        {
            Globals.timeOffset = 0.3f;
        }
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * Globals.speedMultiplier);
    }

    float speedIncrease()
    {
        return gradualIncrease * Time.deltaTime;
    }
}
