using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectcoins : MonoBehaviour {
    public Text gemstext;
    // Use this for initialization
    void Start () {
       int gemsCoin = Convert.ToInt32(FindObjectOfType<SaveData>().LoadGems());
         gemstext.text = Convert.ToString(gemsCoin);
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void writeGems(string gems)
    {
        gemstext.text = gems;

    }
}
