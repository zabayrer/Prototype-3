using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startDelay = 2;
    private float repeateRate = 2;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private playerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
           InvokeRepeating("SpawnObstacle", startDelay, repeateRate);
           playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
         if (playerControllerScript.gameOver == false)
         {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
         }
        
    }
}
