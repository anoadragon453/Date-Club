using UnityEngine;
using System.Collections;

public class AddResponse : MonoBehaviour {
	bool mouseclick = false;
	public GameObject answer;
	int startcont = 0;
	//GameObject response;

	void Start ()
	{
	
	}
	void OnMouseDown(){
		mouseclick = true;
	}
	void Update ()
	{
		if(Input.GetMouseButtonUp((0)))
			mouseclick = false;
		
		if(mouseclick ){
			mouseclick = !mouseclick;
		Instantiate(answer, transform.position, transform.rotation);
		}
		if (startcont > 205) {
			GetComponent<Renderer>().enabled = true;
			//move ();
		}
		else
			GetComponent<Renderer>().enabled = false;
		startcont++;

		
			//response.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);



	}
}


