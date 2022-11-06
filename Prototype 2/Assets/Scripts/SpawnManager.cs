using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float xRange = 18;
    float zPos = 25;

    float xPosL = -28;
    float xPosR = 28;

    float zRangeUp = 25;
    float zRangeDown = -6;

    float startDelay = 2;
    float spawnInterval = 1.5f;

    public GameObject[] animalSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
     }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
        */
    }

    void SpawnRandomAnimal()
    {
        int animalIndexV = Random.Range(0, animalSpawn.Length);
        int animalIndexHL = Random.Range(0, animalSpawn.Length);
        int animalIndexHR = Random.Range(0, animalSpawn.Length);

        Vector3 spawnPosV = new Vector3(Random.Range(-xRange, xRange), 0, zPos);
        Vector3 spawnPosHL = new Vector3(xPosL, 0, Random.Range(zRangeUp, zRangeDown));
        Vector3 spawnPosHR = new Vector3(xPosR, 0, Random.Range(zRangeUp, zRangeDown));

        Instantiate(animalSpawn[animalIndexV], spawnPosV, animalSpawn[animalIndexV].transform.rotation);
        Instantiate(animalSpawn[animalIndexHL], spawnPosHL, Quaternion.Euler(0,90,0));
        Instantiate(animalSpawn[animalIndexHR], spawnPosHR, Quaternion.Euler(0, -90, 0));
    }
}
