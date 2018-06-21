using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public GameObject startUI;
    public PlayerMove pm;
    public GameObject stars;
    bool flag = true;
    
    // Use this for initialization
    void Start () {

        Screen.orientation = ScreenOrientation.PortraitUpsideDown;
        pm.enabled = false;
        stars.SetActive(false);
        startUI.SetActive (true);
        
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.touchCount > 0 )
        {
            pm.enabled = true;
            startUI.SetActive(false);
                flag = false;
        }

        
	}
    
   
}
