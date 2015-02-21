using UnityEngine;
using System.Collections;

public class ZoomScript : MonoBehaviour {

	// Use this for initialization

	int i = -180;
	double change = 0;
	void Start () {
		Camera.main.orthographic = true;
		Camera.main.orthographicSize = 5;

	}
	
	// Update is called once per frame
	void Update () {
		if (i > 0 && i < 10) {
			change += .2;
			Vector3 pos = new Vector3(0,(float)change,-10);
			transform.position = pos;

		}
		i++;


	
	}
}
