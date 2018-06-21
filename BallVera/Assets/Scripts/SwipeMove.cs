using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour {
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desideredposition;
	

    private void Update()
    {
        if (swipeControls.SwipeLeft)
        {
            desideredposition += Vector3.left;


        }
        if (swipeControls.SwipeRight)
        {
            desideredposition += Vector3.right;

        }
        player.transform.position = Vector3.MoveTowards(player.transform.position,desideredposition,2f*Time.deltaTime);
        if (swipeControls.Tap)
        {
            Debug.Log("Tap");

        }
        if (swipeControls.SwipeLeft)
        {
            Debug.Log("Left");

        }
        if (swipeControls.SwipeRight)
        {
            Debug.Log("SwipeRight");

        }
    }
   /* void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;


                case TouchPhase.Ended:
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0f, 0f) - new Vector3(startPos.x, , 0f)).magnitude;
                    if (swipeDistHorizontal > minSwipeDistX)
                    {
                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
                        if (swipeValue > 0)
                        {


                        }
                        else if (swipeValue < 0)
                        {


                        }
                    }
                    break;

            }
        }

    }*/
}
