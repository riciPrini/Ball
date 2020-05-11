using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
    [SerializeField]
    public Rigidbody rb;
    public float Forwardspeed = 4000f;
    public float rightLeftSpeed = 100f;
    public float swipeForce = 75f;
    public bool flag = true;
    float moveSpeed = 1000f;
    public Material redMaterial, yellowMaterial, blueMaterial, greenMaterial, orangeMaterial, pinkMaterial, purpleMaterial, waterMaterial, whiteMaterial;
    public Text record;
    public TextMesh gameRecord;
    public GameObject pause;
    public StartGame startgame;
    public GameObject score;
    public GameObject recordText;
    public GameObject stars;
    public GameObject gems;
    public GameObject gemma_img; //dioporco è l'ultimo gioco di merda che faccio con sto unity del cazzo.
    Touch touch;
    Vector3 touchPosition, whereToMove;
    bool isMoving = false;

    float previousDistanceToTouchPos, currentDistanceToTouchPos;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pause.SetActive(true);
        startgame.enabled = false;
        score.SetActive(true);
        stars.SetActive(true);
        recordText.SetActive(true);
        gems.SetActive(true);
        //string material = FindObjectOfType<SaveData>().LoadColor();
        //Material(material);

        record.text = FindObjectOfType<SaveData>().LoadRecord();
        gameRecord.transform.position = new Vector3(-24,100,Convert.ToInt32(record.text));
       gameRecord.text =("Record"+ "\n   "+FindObjectOfType<SaveData>().LoadRecord());

    }
    // void Material(string color)
    // {
    //     switch (color)
    //     {
    //         case "red":
    //             GetComponent<Renderer>().material = redMaterial;
    //             break;
    //         case "yellow":
    //             GetComponent<Renderer>().material = yellowMaterial;
    //             break;
    //         case "blue":
    //             GetComponent<Renderer>().material = blueMaterial;
    //             break;
    //         case "green":
    //             GetComponent<Renderer>().material = greenMaterial;
    //             break;
    //         case "orange":
    //             GetComponent<Renderer>().material = orangeMaterial;
    //             break;
    //         case "pink":
    //             GetComponent<Renderer>().material = pinkMaterial;
    //             break;
    //         case "purple":
    //             GetComponent<Renderer>().material = purpleMaterial;
    //             break;
    //         case "water":
    //             GetComponent<Renderer>().material = waterMaterial;
    //             break;
    //         case "white":
    //             GetComponent<Renderer>().material = whiteMaterial;
    //             break;
    //     }

    // }
    void FixedUpdate()
    {
        if (flag)
        {
            rb.AddForce(0, 0, Forwardspeed * Time.fixedDeltaTime);

            if (isMoving)
                currentDistanceToTouchPos = (touchPosition - transform.position).magnitude;

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                var halfScreen = Screen.width * 0.5f;

                if (touch.position.x > halfScreen)
                    rb.position=new Vector3( 3.8f, transform.position.y , transform.position.z);
                else
                    rb.position=new Vector3( -3.8f, transform.position.y , transform.position.z);
            }

            //if (currentDistanceToTouchPos > previousDistanceToTouchPos)
            //{
            //    isMoving = false;
            //    rb.velocity = Vector3.zero;
            //}

            if (isMoving)
                previousDistanceToTouchPos = (touchPosition - transform.position).magnitude;

            if (Input.GetKey("d"))
            {
                if(transform.position.x==-3.8f){
                         Debug.Log("ALANGAYd");
                         rb.position= new Vector3( 0, transform.position.y , transform.position.z);
                }
                else{
                
                 rb.position= new Vector3( 3.8f, transform.position.y , transform.position.z);
                }
                

                

            }
            if (Input.GetKey("a"))
            {
                 if(transform.position.x==3.8f){
                     Debug.Log("ALANGAYs");
                        rb.position= new Vector3( 0, transform.position.y , transform.position.z);
                    }
                    else{
                    rb.position= new Vector3( -3.8f, transform.position.y , transform.position.z);
                    }
                   
                
            }
            if (rb.position.y < -1f)
            {

                FindObjectOfType<GameOver>().endGame();
            }
            if (rb.position.x <= -5f || rb.position.x >= 5f)
            {
                FindObjectOfType<Explosion>().explode();
                FindObjectOfType<GameOver>().endGame();
                
            }
        }
        
        
    }
}
