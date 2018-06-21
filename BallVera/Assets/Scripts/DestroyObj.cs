using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObj : MonoBehaviour {
   
    public int gemsCoin = 0;
   
    public void Start()
    {
       gemsCoin=Convert.ToInt32(FindObjectOfType<SaveData>().LoadGems());
       // gemstext.text = Convert.ToString(gemsCoin);

    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

          gemsCoin++;
            FindObjectOfType<Collectcoins>().writeGems(Convert.ToString(gemsCoin));
           // gemstext.text = Convert.ToString(gemsCoin);
          FindObjectOfType<SaveData>().SaveGems(Convert.ToString(gemsCoin));
            Destroy(this.gameObject);

        }
    }
    

}
