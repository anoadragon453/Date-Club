using UnityEngine;
using System.Collections;


public class MoveDragAndDrop : MonoBehaviour {
	bool drag = false;
	bool stopMoving = false;
	bool mouseclick = false;
	public GameObject repoman;
	private Vector3 mousePosition;
	public float moveSpeed = 1.0f;
	double change = 0;
	// Use this for initialization
	void Start () {
	//	transform.position = Input.mousePosition;
	
	}
	public bool getMove(){
		return mouseclick;
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			drag = !drag;
		} 
		if (Input.GetMouseButtonUp (0)) {
			stopMoving = true;
			drag = !drag;

		}
		if (!drag && !stopMoving) {
			renderer.enabled = true;
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = Vector2.Lerp (mousePosition, mousePosition, moveSpeed);
		}
		if (stopMoving) {
			if(mousePosition.y > 4.125)
				transform.position = new Vector3(-8.5f, 5.5f, 0);
				
			else if(mousePosition.y < 4.125 && mousePosition.y > 1.375)
				transform.position = new Vector3(-8.5f,2.75f,0);
			else
				transform.position = new Vector3(-8.5f,0.2f,0);
		
			transform.position = new Vector3((float)(transform.position.x + change), transform.position.y, transform.position.z);
		
			change += .02;

			mouseclick = true;

			//Debug.Log(mousePosition);
		}

	


	
	}
}
