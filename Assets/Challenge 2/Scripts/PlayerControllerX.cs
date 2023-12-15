using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnTimer;
    private float minimumInterval = 1.0f;

    // Update is called once per frame
    void Update()
    {
        dogSpawnTimer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dogSpawnTimer >= minimumInterval)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawnTimer = 0;
            }

            
        }
    }
}
