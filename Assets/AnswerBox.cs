using UnityEngine;
using System.Collections;

public class AnswerBox : MonoBehaviour {
	public GameObject gBox;
	// Use this for initialization
	void Start () {
		/*DisplayQuestion d = (DisplayQuestion) gBox.GetComponent("DisplayQuestion");
		int kkk = d.getBox ();
		Debug.Log(kkk);
		TextMesh t = (TextMesh)GetComponent ("TextMesh");
		t.text = kkk.ToString();*/

		GameObject displayQuestionObject = GameObject.Find ("qq");
		DisplayQuestion displayQuestionScript = displayQuestionObject.GetComponent<DisplayQuestion> ();
		int kkk = displayQuestionScript.boxNumber;
		Debug.Log ("Box Number: " + kkk);
		TextMesh t = (TextMesh)GetComponent ("TextMesh");
		t.text = kkk.ToString ();
	}
	 
	// Update is called once per frame
	void Update () {
	
	}
}
