using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteGround : MonoBehaviour {

    public GameObject terrain;
    
    public GameObject player;
    public GameObject spawn;
    public bool terrainPlay = true;


    //--------------//
    // Use this for initialization
    void Start () {
		
	}
    public void Reset()
    {
        terrain.transform.position=new Vector3(0,0,0);
        terrain.transform.localScale = new Vector3(17, 1, 100);
    }
    // Update is called once per frame
    void LateUpdate () {
        if(terrainPlay)
        terrain.transform.localScale+= new Vector3(0, 0,5f);
           

        
	}
}
