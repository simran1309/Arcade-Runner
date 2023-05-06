using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
   

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private Vector3 spawnPos2 = new Vector3(60, 0, 0);
    private Vector3 spawnPos3 = new Vector3(45, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 3;
    
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Instantiate(obstaclePrefab2, spawnPos2, obstaclePrefab2.transform.rotation);
            Instantiate(obstaclePrefab3, spawnPos3, obstaclePrefab3.transform.rotation);
           

        }
    }



}    


   
   