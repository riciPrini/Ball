
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public Transform go;
    public Text txt;
	
	// Update is called once per frame
	void Update () {
        txt.text = go.position.z.ToString("0");
	}
}
