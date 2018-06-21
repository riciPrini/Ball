using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour {

    public GameObject shop;
    public GameObject gameover;
    public GameObject redImg, yellImg, blueImg, greenImg, orangeImg, pinkImg, purpleImg, waterImg, whiteImg;
    
    public void red()
    {
        //color selected
        redImg.SetActive(true);
       yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Red();
    }
    public void yellow()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(true);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Yellow();
    }
    public void blue()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(true);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Blue();
    }
    public void green()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(true);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Green();
    }
    public void orange()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(true);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Orange();
    }
    public void pink()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(true);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Pink();
    }
    public void purple()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(true);
        waterImg.SetActive(false);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Purple();
    }
    public void water()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(true);
        whiteImg.SetActive(false);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().Water();
    }
    public void white()
    {
        //color selected
        redImg.SetActive(false);
        yellImg.SetActive(false);
        blueImg.SetActive(false);
        greenImg.SetActive(false);
        orangeImg.SetActive(false);
        pinkImg.SetActive(false);
        purpleImg.SetActive(false);
        waterImg.SetActive(false);
        whiteImg.SetActive(true);
        //------------------------//
        //set color
        FindObjectOfType<ColorScript>().White();
    }
    public void back()
    {

        shop.SetActive(false);
        gameover.SetActive(true);
    }
}
