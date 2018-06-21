using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimations : MonoBehaviour {
    public Animator Camera1, ball1,panel1;
    public Animator Camera2, ball2, panel2;
    public Animator Camera3, ball3, panel3;
    public Animator Camera4, ball4, panel4;
    public Animator Camera5, ball5, panel5;
    public Animator Camera6,ball6, panel6;
    public Camera cam1, cam2, cam3, cam4, cam5, cam6;
    // Use this for initialization
    void Start () {
        ball1.enabled = false;
        panel1.enabled = false;
        Camera1.enabled = false;
        cam1.enabled = false;
        //-----------------------//
        ball2.enabled = false;
        panel2.enabled = false;
        Camera2.enabled = false;
        cam2.enabled = false;
        //-----------------------//
        ball3.enabled = false;
        panel3.enabled = false;
        Camera3.enabled = false;
        cam3.enabled = false;
        //-----------------------//
        ball4.enabled = false;
        panel4.enabled = false;
        Camera4.enabled = false;
        cam4.enabled = false;
        //-----------------------//
        ball5.enabled = false;
        panel5.enabled = false;
        Camera5.enabled = false;
        cam5.enabled = false;
        //-----------------------//
        ball6.enabled = false;
        panel6.enabled = false;
        Camera6.enabled = false;
        cam6.enabled = false;
    }
	
	// Update is called once per frame
    public void BOX1()
    {
            ball1.enabled = true;
            panel1.enabled = true;
        Camera1.enabled = true;
        cam1.enabled = true;
    }
    public void BOX2()
    {
        ball2.enabled = true;
        panel2.enabled = true;
        Camera2.enabled = true;
        cam2.enabled = true;

    }
    public void BOX3()
    {
        ball3.enabled = true;
        panel3.enabled = true;
        Camera3.enabled = true;
        cam3.enabled = true;

    }
    public void BOX4()
    {
        ball4.enabled = true;
        panel4.enabled = true;
        Camera4.enabled = true;
        cam4.enabled = true;

    }
    public void BOX5()
    {

        ball5.enabled = true;
        panel5.enabled = true;
        Camera5.enabled = true;
        cam5.enabled = true;
    }
    public void BOX6()
    {
        ball6.enabled = true;
        panel6.enabled = true;
        Camera6.enabled = true;
        cam6.enabled = true;

    }
   
    void Update () {
       
    }
}
