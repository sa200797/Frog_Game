using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [Range(0, 1)]
    public float spawnDelay =0.85f;

    public float nextTimeToSpawn;

    public GameObject PlayerPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            SpawnBoat();
             
            nextTimeToSpawn = Time.time + spawnDelay; 
        }

        

    }

    void SpawnBoat()
    {
        Instantiate(PlayerPrefab, transform.position, transform.rotation);
    }
}
