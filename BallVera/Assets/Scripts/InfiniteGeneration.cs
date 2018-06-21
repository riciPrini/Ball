using UnityEngine;

public class InfiniteGeneration : MonoBehaviour {
    public int depth = 500;
    public int width = 20;
    public int height = 1;
    public float scale = 20f;
    public float OffsetX = 100f;
    public float OffsetY = 100f;
    public Transform[] spawnpoint;
    public Rigidbody rb;
    Vector3 v;
     void Start()
    {
         
        
        OffsetY = Random.Range(0f,999f);
        OffsetX = Random.Range(0f, 999f);
        InvokeRepeating("SpawnObject",1f,1f);
         v= new Vector3(5,1,0);
    }
    void Update()
    {
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GeneraitTerrain(terrain.terrainData);
        OffsetX += Time.deltaTime;
       
    }

   
    TerrainData GeneraitTerrain(TerrainData terrainData)
    {
        
        terrainData.size = new Vector3(width, depth, height);
        terrainData.SetHeights(0, 0, generateHeights());
        return terrainData;
    }

    public float[,] generateHeights()
    {
        float[,] heights = new float[width, height];
        for (int x=0; x<width;x++)
        {

            for (int y= 0; y<height;y++)
            {
                heights[x, y] = CalculateHeights(x,y);

            }
        }
        return heights;

    }
    public float CalculateHeights(int x,int y)
    {
        float xCoord =(float) x / width* scale +OffsetX;
        float yCoord = (float)y / height * scale +OffsetY;
        return Mathf.PerlinNoise(xCoord,yCoord);

    }
}
