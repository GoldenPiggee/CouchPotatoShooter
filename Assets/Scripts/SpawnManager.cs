using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject couch;

    private float spawnRangeX = 10;
    private float spawnPosY = 15;

    private float startDelay = 2;
    private float spawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CouchSpawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CouchSpawn()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        Instantiate(couch, spawnpos, transform.rotation);
    }
}