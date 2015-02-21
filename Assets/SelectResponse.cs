using UnityEngine;
using System.Collections;

public class SelectResponse : MonoBehaviour {
	double change = 0;
	public Sprite questionbutton;
	public Sprite answerbutton;
	public GameObject gBox;
	public GameObject repoman;
	double flip = 0;
	int boxNum = 0;
	// Use this for initialization
	void Start () {


			GetComponent<SpriteRenderer> ().sprite = questionbutton;

		int pos = Random.Range (0, 3);
		if (pos == 0)
			transform.position = new Vector3 (15, 5.5f, 0);
		else if (pos == 1)
			transform.position = new Vector3 (15, 2.75f, 0);
		else {
			transform.position = new Vector3(15,0.2f,0);
		}
	}
	public int getBoxNum(){
		return boxNum;
	}
	public void makeNew(){
		int select = Random.Range (0, 2);
		if (select == 0)
			GetComponent<SpriteRenderer> ().sprite = questionbutton;
		else
			GetComponent<SpriteRenderer> ().sprite = answerbutton;
		int pos = Random.Range (0, 3);
		if (pos == 0)
			transform.position = new Vector3 (15, 5.5f, 0);
		else if (pos == 1)
			transform.position = new Vector3 (15, 2.75f, 0);
		else {
			transform.position = new Vector3(15,0.2f,0);
		}
	}
	// Update is called once per frame
	void Update () {
		/*if (flip % 10000000000000000 == 0) {
			int pos = Random.Range (0, 3);
			Vector3 popo;
			if (pos == 0)
				popo = new Vector3 (15, 5.5f, 0);
			else if (pos == 1)
				popo = new Vector3 (15, 2.75f, 0);
			else {
				popo = new Vector3(15,0,0);
			}
			Instantiate(this, popo, transform.rotation);
		}*/
		if (transform.position.x < -15) {
			float k = repoman.GetComponent<ControlReputation> ().reputationLevel;
			repoman.GetComponent<ControlReputation> ().reputationLevel = k - 15;
			makeNew ();
		}
		else
		transform.position = new Vector3((float)(transform.position.x - .035), transform.position.y, transform.position.z);
	
		//flip+=.00000001;
	
	}
}
