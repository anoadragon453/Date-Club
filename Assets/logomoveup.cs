using UnityEngine;
using System.Collections;

public class logomoveup : MonoBehaviour {
	public int count;

	// Use this for initialization
	void Start () {
		count = 0;
		Debug.Log("Time to go not Slow!");
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count > 300) {
			if (count > 310 && count < 418) {
				transform.position = new Vector2 (transform.position.x, transform.position.y + .1f);
				Debug.Log ("Time to go Slow!");
			} 
			if (count > 590 && count < 630) {
				transform.position = new Vector2 (transform.position.x, transform.position.y + .05f);
			}
		}	
	}
}
