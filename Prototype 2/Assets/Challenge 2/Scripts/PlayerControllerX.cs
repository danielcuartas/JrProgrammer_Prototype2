using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    bool valid = true;
    public GameObject dogPrefab;
    float timer = 0;
    float timeSpawned = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log("timer" + timer);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer - timeSpawned > 2)
            {
                valid = true;
            }

            if (valid)
            {
                timeSpawned = timer;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                valid = false;
            }
            
        }
    } 
}
