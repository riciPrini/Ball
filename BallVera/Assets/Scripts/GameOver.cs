using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public GameObject stars;
    public GameObject Gameover;
     Spawn spawn;
    public GameObject play;
    public Text score;
    public Text newRecord;
    public Transform player;
    public PlayerMove pm;
    public GameObject pause;
    public void Start()
    {
        Gameover.SetActive(false);
    }
    public void Play()
    {
        Gameover.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        spawn.flag = true;
        pm.flag = true;

    }
    
	public void endGame()
    {


        //---------------------//
        newRecord.enabled = false;
        pause.SetActive(false);
        Gameover.SetActive(true);
        play.SetActive(false);
        stars.SetActive(false);
        stopPlayer();
        score.text = player.position.z.ToString("0");
        record(score.text);
        
        
    }
    public void record(string score)
    {
        string record = FindObjectOfType<SaveData>().LoadRecord();

        //   FindObjectOfType<SaveData>().SaveRecord(player.position.z.ToString("0"));
        if (Convert.ToInt32(score)> Convert.ToInt32(record))
        {
            FindObjectOfType<SaveData>().SaveRecord(score);
            newRecord.enabled = true;
        }
        



    }
    void stopPlayer()
    {
         pm.enabled = false;
        pm.flag = false;
        //spawn.flag = false;
      
    }
  public  void Restart()
    {
        // FindObjectOfType<GameOver>().record(this.score.text);

        pause.SetActive(true);
        //pm.enabled=true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

       

    }
}
