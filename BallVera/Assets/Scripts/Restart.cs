using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {
    public Text record;
    public GameObject shop;
    public GameObject gameover;
    public void RestartLevel()
    {
        FindObjectOfType<GameOver>().Restart();
       // FindObjectOfType<GameOver>().Play();
        record.text = FindObjectOfType<SaveData>().LoadRecord();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
	public void Quit()
    {
        Application.Quit();

    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Play()
    {
        FindObjectOfType<GameOver>().Play();

    }
}
