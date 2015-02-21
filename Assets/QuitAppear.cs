using UnityEngine;
using System.Collections;

public class QuitAppear : MonoBehaviour {
	public int count;
	
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count == 690) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + 10f);
		}	
	}
}
