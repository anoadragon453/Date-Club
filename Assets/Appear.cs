using UnityEngine;
using System.Collections;

public class Appear : MonoBehaviour {
	int starts = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (starts > 205)
			GetComponent<Renderer>().enabled = true;
	else {
			GetComponent<Renderer>().enabled=false;
		}
		starts++;
	}
}
