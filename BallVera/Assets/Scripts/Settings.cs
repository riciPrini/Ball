using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
    public GameObject SettingsUI;
    public GameObject back;
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
            SettingsUI.SetActive(true);
            back.SetActive(true);
            Gamepaused = true;
        }
        else
        {
            pm.enabled = true;
            Time.timeScale = 1f;
            SettingsUI.SetActive(false);
            back.SetActive(false);
            Gamepaused = false;
        }
    }
}
