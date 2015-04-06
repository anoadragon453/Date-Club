using UnityEngine;
using System.Collections;

public class ControlReputation : MonoBehaviour {
	
	public float reputationLevel; // From 0 to 100
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (reputationLevel > 0 &&reputationLevel <100)
			transform.localScale = new Vector3 (reputationLevel / 100, transform.localScale.y, transform.localScale.z);
		else
			Application.LoadLevel ("DeathScene");
	}
}
