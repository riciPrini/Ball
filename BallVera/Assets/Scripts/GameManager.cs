
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    public GameObject gameover;
    public void endGame()
    {
        gameover.SetActive(true);
      
    }
   
}
