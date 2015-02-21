using UnityEngine;
using System.Collections;

public class changePos : MonoBehaviour {
	public  Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	public  void setPos(Vector3 newPos){
		pos = newPos;
	}
	// Update is called once per frame
	void Update () {
		transform.position = pos;
	}
}
