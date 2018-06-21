using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainGenerator : MonoBehaviour {
    public Transform[] spawnPoints = new Transform[8];

    public GameObject blockPrefab;
    public GameObject spawn;
    public PlayerMove pm;

    public float timeBetweenWaves = 1f;
    public bool spawnNext = true;
    public float timeToSpawn = 5000f;
    public bool flag = true;
    //--------//
    private Transform playertransform;
    private float spawnZ = 0.0f;
    private float tilelength = 10.0f;
    private int ntiles = 1;
    private float safe = 50f;
    public GameObject[] titlePrefabs;
    private List<GameObject> activetiles;
    // Use this for initialization
    void Start () {
      //  pm.enabled = false;
        activetiles = new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Play").transform;
        for (int i = 0; i < ntiles; i++)
        {
            spawntile();

        }
    }
	
	// Update is called once per frame
	void LateUpdate () {
       
        if ((playertransform.position.z +45) - safe > (spawnZ - tilelength))
        {
            spawntile();
            Deletetile();
            if (Time.time >= timeToSpawn && flag)
        {
            SpawnBlocks();
            spawner();
            timeToSpawn = Time.time + timeBetweenWaves;

        }
        }
    }
    void spawntile(int prefabindex = -1)
    {
        GameObject go;
        go = Instantiate(titlePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tilelength;
        activetiles.Add(go);
    }

    void Deletetile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
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
