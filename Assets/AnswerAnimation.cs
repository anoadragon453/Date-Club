using UnityEngine;
using System.Collections;

public class AnimateAcrossScreen : MonoBehaviour {

	// Use this for initialization
	int startcont = 0;
	double change = 0;
	void Start () {
		transform.position = new Vector3 (-15, 4.5f, 0);
	
	}
	void move(){
		change += .1;
		Vector3 pos = new Vector3((float)(change-15),4.5f, 0);
		transform.position = pos;

	}
	
	// Update is called once per frame
	void Update () {
		if (startcont > 205) {
			GetComponent<Renderer>().enabled = true;
			move ();
		}
		else
			GetComponent<Renderer>().enabled = false;
		startcont++;
	
	}
}
