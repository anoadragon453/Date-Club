using UnityEngine;
using System.Collections;

public class quesDrag : MonoBehaviour {
	
	bool drag = false;
	public GameObject otherbox1;
	public GameObject otherbox2;
	public GameObject otherbox3;
	public GameObject woot;
	
	bool stopMoving = false;
	int count = 0;
	private Vector3 mousePosition;
	public float moveSpeed = 1.0f;
	public GameObject button;
	
	bool mouseclick = false;
	// Use this for initialization
	void Start () {
		
	}
	public bool getMove(){
		return stopMoving;
	}
	void OnMouseDown(){
	//	woot.GetComponent<collisionScript> ().selectedAns = this.name;
	//	Debug.Log (this.name);
		mouseclick = true;



		//count++;
	}
	void OnMouseUp(){
		drag = true;
		stopMoving = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (mouseclick) {
			Instantiate(button, transform.position, transform.rotation);
			
			GetComponent<changePos>().setPos(new Vector3(20.0f, -20.0f,0.0f));
			otherbox2.GetComponent<changePos>().setPos(new Vector3 (-20.1f, -20.5f, 0.0f));
			otherbox3.GetComponent<changePos>().setPos(new Vector3(-20.0f, -20.0f,0.0f));
			otherbox1.GetComponent<changePos>().setPos(new Vector3(-20.0f, -20.0f,0.0f));
			count++;
			renderer.enabled = true;
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			button.transform.position = Vector2.Lerp (mousePosition, mousePosition, moveSpeed);
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			mouseclick = !mouseclick;
			
		}
		else if(drag){
			//Instantiate(button, mousePosition, transform.rotation);
			sew.setVisible(true);
			ShowMore.setVisible(true);
			sew.setRigidBody(true);
			ShowMore.setRigidBody(true);
			drag = !drag;
			stopMoving = true;
			
			
			
		}
	}
}
