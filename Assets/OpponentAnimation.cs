using UnityEngine;
using System.Collections;

public class OpponentAnimation : MonoBehaviour {

	// Use this for initialization
	int startcont = 0;
	double change = 0;
	int startPos;
	void Start () {
		int rand = Random.Range(1, 4);
		if (rand < 2)
			startPos = 3;
		else if (rand ==2)
			startPos = 5;
		else 
			startPos = 7;

		//else if(rand > 3)
		//	startPos = 7;
		transform.position = new Vector3 (15, startPos, 0);
		//7
		//3

		
	}
	void move(){
		change += .05;
		Vector3 pos = new Vector3((float)(15-change),startPos, 0);
		transform.position = pos;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (startcont > 205) {
			renderer.enabled = true;
			move ();
		}
		else
			renderer.enabled = false;
		startcont++;
		
	}
}
