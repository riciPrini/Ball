using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    public PlayerMove pm;
    public PlayerMove gm;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Obstacle")
        {
            FindObjectOfType<GameOver>().endGame();
            pm.enabled = false;

        }
        if (collision.collider.tag=="Gemma") {

        }
    }
}
