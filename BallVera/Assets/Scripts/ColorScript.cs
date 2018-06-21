using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {
    
    
    public void Red()
    {


        FindObjectOfType<SaveData>().SaveColor("red");
    }
    public void Yellow()
    {


        FindObjectOfType<SaveData>().SaveColor("yellow");
    }
    public void Blue()
    {


        FindObjectOfType<SaveData>().SaveColor("blue");

    }
    public void Green()
    {

        FindObjectOfType<SaveData>().SaveColor("green");
    }
    public void Orange()
    {

        FindObjectOfType<SaveData>().SaveColor("orange");

    }
    public void Pink()
    {

        FindObjectOfType<SaveData>().SaveColor("pink");

    }
    public void Purple()
    {

        FindObjectOfType<SaveData>().SaveColor("purple");

    }
    public void Water()
    {

        FindObjectOfType<SaveData>().SaveColor("water");

    }
    public void White()
    {

        FindObjectOfType<SaveData>().SaveColor("white");

    }

}
