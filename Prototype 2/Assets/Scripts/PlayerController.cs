using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int lives = 3;
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xRange = 30f;
    public float zRangeUp = 20f;
    public float zRangeDown = -5f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate((Vector3.right * horizontalInput * Time.deltaTime * speed) + (Vector3.forward * verticalInput * speed * Time.deltaTime));
 

        // Boundaries
        // x axis
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, 0, transform.position.z);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, 0, transform.position.z);
        }

        // z axis
        if (transform.position.z <= zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, 0, zRangeDown);
        }

        if (transform.position.z >= zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, 0, zRangeUp);
        }

        // Projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
