using UnityEngine;
using System.Collections;

public class IdleAnimation : MonoBehaviour {

	// Use this for initialization
	float i = .1f;
	int flip = 0;
	int startcont = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (flip % 60 == 0 && startcont > 205) {
			Vector3 currPos = transform.position;
		
			transform.position = new Vector3(currPos.x, currPos.y + i, currPos.z);
			i *= -1.0f;

		}
		startcont++;

		flip++;

	
	}
}
