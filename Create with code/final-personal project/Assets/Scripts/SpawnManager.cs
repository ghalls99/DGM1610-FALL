using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject obstaclePrefab;
    public GameObject[] obstacleLength;
    private Vector3 spawnPos = new Vector3(1, 70f, -60);
    private float startDelay = 2;
    private float repeatRate = 2;
    private float spawnInterval = 0.5f;
    private playercontroller playerControllerScript;
    public int obstacleIndex = 3;
    private float spawnRangeX = 5;
    private float spawnRangeZ =300;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playercontroller>();
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        int obstacleIndex = Random.Range(0, obstacleLength.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstacleLength[obstacleIndex], spawnPos, obstacleLength[obstacleIndex].transform.rotation);
        }
        
    }
}