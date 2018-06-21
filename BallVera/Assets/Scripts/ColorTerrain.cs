using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTerrain : MonoBehaviour {
    public Material redMaterial, yellowMaterial, blueMaterial, greenMaterial, orangeMaterial, pinkMaterial, purpleMaterial, waterMaterial, whiteMaterial;
    private void Start()
    {
       
        string material = FindObjectOfType<SaveData>().LoadColor();
        Material(material);
      
    
    }
    void Material(string color)
    {
        switch (color)
        {
            case "red":
                GetComponent<Renderer>().material = redMaterial;
                break;
            case "yellow":
                GetComponent<Renderer>().material = yellowMaterial;
                break;
            case "blue":
                GetComponent<Renderer>().material = blueMaterial;
                break;
            case "green":
                GetComponent<Renderer>().material = greenMaterial;
                break;
            case "orange":
                GetComponent<Renderer>().material = orangeMaterial;
                break;
            case "pink":
                GetComponent<Renderer>().material = pinkMaterial;
                break;
            case "purple":
                GetComponent<Renderer>().material = purpleMaterial;
                break;
            case "water":
                GetComponent<Renderer>().material = waterMaterial;
                break;
            case "white":
                GetComponent<Renderer>().material = whiteMaterial;
                break;
        }

    }
}
