using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
   public GameObject pauseUI;
   public PlayerMove pm;
    bool Gamepaused = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void pause()
    {
        if (!Gamepaused)
        {
        pm.enabled = false;
        Time.timeScale = 0f;
        pauseUI.SetActive(true);
        Gamepaused = true;
        }
        else
        {
            pm.enabled = true;
            Time.timeScale = 1f;
            pauseUI.SetActive(false);
            Gamepaused = false;
        }
    }
}
