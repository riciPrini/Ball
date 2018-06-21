using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

   public  Transform[] spawnPoints=new Transform[8];
   
    public GameObject blockPrefab;
    public GameObject spawn;
    public PlayerMove pm;
   
    public float timeBetweenWaves = 1f;
    public bool spawnNext=true;
    public float timeToSpawn = 5000f;
    public bool flag = true;
    public void Reset()
    {
        Destroy(gameObject);
        spawn.transform.position=new Vector3(0,1,50);
        timeBetweenWaves = 1f;
        timeToSpawn = 5000f;
    }
    void Start()
    {
        pm.enabled = false;

    }
    void LateUpdate()
    {

        if (Time.time >= timeToSpawn && flag)
        {
            SpawnBlocks();
            spawner();
           timeToSpawn = Time.time + timeBetweenWaves;
            
        }
        

    }
    void spawner()
    {

        
            spawn.transform.Translate(new Vector3(0, 0, 100));


        //spawnNext = false;



    }
    void SpawnBlocks()
    {
        //int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
                pm.enabled = true;
           // spawnNext = false;
               Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                
                
            

        }
        
        /*spawnPoints[0].transform.Translate(new Vector3(0, 0, 20 ));
            spawnPoints[1].transform.Translate(new Vector3(0, 0, 20));
            spawnPoints[2].transform.Translate(new Vector3(0, 0, 20));
            spawnPoints[3].transform.Translate(new Vector3(0, 0, 20));
            spawnPoints[4].transform.Translate(new Vector3(0, 0, 20));*/
            
    }
    }
