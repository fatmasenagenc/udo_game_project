using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    [SerializeField] private GameObject redCube;
    [SerializeField] private GameObject greenCube;
    [SerializeField] private GameObject blueCube;

    [SerializeField] private GameObject redSpawn;
    [SerializeField] private GameObject greenSpawn;
    [SerializeField] private GameObject blueSpawn;

    private float spawnTime;
    private float time;

    void Start()
    {
        spawnTime = generateRandomTime() + Globals.timeOffset;

        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            int selection = Random.Range(1, 4);

            if (selection == 1)
            {
                spawnRed();
            } else if (selection == 2)
            {
                spawnGreen();
            } else
            {
                spawnBlue();
            }

            spawnTime = generateRandomTime() + Globals.timeOffset;
        }
    }

    float generateRandomTime()
    {
        return Random.value;
    }
    void spawnRed()
    {
        time = 0;
        Vector3 pos = new Vector3(redSpawn.transform.position.x,
            redSpawn.transform.position.y, redSpawn.transform.position.z);
        Instantiate(redCube, pos, Quaternion.identity, redSpawn.transform);
    }

    void spawnGreen()
    {
        time = 0;
        Vector3 pos = new Vector3(greenSpawn.transform.position.x,
            greenSpawn.transform.position.y, greenSpawn.transform.position.z);
        Instantiate(greenCube, pos, Quaternion.identity, greenSpawn.transform);
    }

    void spawnBlue()
    {
        time = 0;
        Vector3 pos = new Vector3(blueSpawn.transform.position.x,
            blueSpawn.transform.position.y, blueSpawn.transform.position.z);
        Instantiate(blueCube, pos, Quaternion.identity, blueSpawn.transform);
    }
}
