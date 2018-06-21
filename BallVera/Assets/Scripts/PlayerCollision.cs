using UnityEngine;

public class PlayerCollision : MonoBehaviour {
        
   
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag=="Obstacle")
        {
            GetComponent<PlayerMove>().enabled = false;
            FindObjectOfType<GameManager>().endGame();


        }
        
    }
    

        

    
}
