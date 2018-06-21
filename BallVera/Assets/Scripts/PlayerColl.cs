using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    public PlayerMove pm;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Obstacle")
        {
            FindObjectOfType<GameOver>().endGame();
            pm.enabled = false;

        }
    }
}
