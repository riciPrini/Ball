using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour {
    public GameObject player1, player2;
	public void OnChangeValue()
    {
        bool flag = gameObject.GetComponent<Toggle>().isOn;
        if (flag)
        {

            player1.SetActive(true);
            player2.SetActive(false);
        }else
        {
            player1.SetActive(false);
            player2.SetActive(true);

        }
    }
}
