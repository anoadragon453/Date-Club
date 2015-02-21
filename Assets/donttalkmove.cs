using UnityEngine;
using System.Collections;

public class donttalkmove : MonoBehaviour {
	public int count;
	
	// Use this for initialization
	void Start () {
		count = 0;
		Debug.Log("Time to go not Slow!");
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count > 150) {
			if (count > 190 && count < 270) {
				transform.position = new Vector2 (transform.position.x - .1f, transform.position.y);
				Debug.Log ("Time to go Slow!");
			} else {
				transform.position = new Vector2 (transform.position.x - .5f, transform.position.y);
			}
		}	
	}
}
