using UnityEngine;
using System.Collections;

public class sew : MonoBehaviour {

	public GameObject otherButton;
	public GameObject textbox1;
	public GameObject textbox2;
	public static bool visible = true;
	public GameObject textbox3;
	public GameObject textbox4;
	public static bool hasBody = true;
	public GameObject t1;
	public GameObject t2;
	public GameObject t3;
	public GameObject t4;

	
	
	// Use this for initialization
	int startcont = 0;
	void Start () {
		
	}
	
	public static void setVisible(bool vis){
		visible = vis;
	}
	public static void setRigidBody(bool vis){
		hasBody = vis;
	}
	void OnMouseDown(){
		visible = false;
		ShowMore.setVisible (false);
		ShowMore.setRigidBody (false);
		hasBody = false;
		//show.setShowButton(false);
		textbox1.GetComponent<changePos>().setPos(new Vector3(-7.1f, -1.5f,0.0f));
		textbox2.GetComponent<changePos>().setPos(new Vector3 (-7.1f, -2.5f, 0.0f));
		textbox3.GetComponent<changePos>().setPos(new Vector3(-3.9f, -1.5f,0.0f));
		textbox4.GetComponent<changePos>().setPos(new Vector3(-3.9f, -2.5f,0.0f));
		int lol = (int)Random.Range(0,12);
		t1.GetComponent<DisplayQuestion>().boxNumber = lol;
		DisplayQuestion.Question fuck = (DisplayQuestion.Question)t1.GetComponent<DisplayQuestion>().manQuestions[lol];
		string swg1 = fuck.getQuestionText();
		int lol2 = (int)Random.Range(0,12);
		t2.GetComponent<DisplayQuestion>().boxNumber = lol2;
		DisplayQuestion.Question fuck2 = (DisplayQuestion.Question)t2.GetComponent<DisplayQuestion>().manQuestions[lol2];
		string swg2 = fuck2.getQuestionText();
		int lol3 = (int)Random.Range(0,12);
		t3.GetComponent<DisplayQuestion>().boxNumber = lol3;
		DisplayQuestion.Question fuck3 = (DisplayQuestion.Question)t3.GetComponent<DisplayQuestion>().manQuestions[lol3];
		string swg3 = fuck3.getQuestionText();
		int lol4 = (int)Random.Range(0,12);
		t4.GetComponent<DisplayQuestion>().boxNumber = lol4;
		DisplayQuestion.Question fuck4 = (DisplayQuestion.Question)t4.GetComponent<DisplayQuestion>().manQuestions[lol4];
		string swg4 = fuck4.getQuestionText();
		
		t1.GetComponent<TextMesh>().text = ResolveTextSize( swg1, 27);
		t2.GetComponent<TextMesh> ().text = ResolveTextSize( swg2, 27);
		t3.GetComponent<TextMesh> ().text = ResolveTextSize( swg3, 27);
		t4.GetComponent<TextMesh> ().text = ResolveTextSize( swg4, 27);
		
		//showButton = false;
	}
	private string ResolveTextSize(string input, int lineLength){
		
		// Split string by char " "         
		string[] words = input.Split(" "[0]);
		
		// Prepare result
		string result = "";
		
		// Temp line string
		string line = "";
		
		// for each all words        
		foreach(string s in words){
			// Append current word into line
			string temp = line + " " + s;
			
			// If line length is bigger than lineLength
			if(temp.Length > lineLength){
				
				// Append current line into result
				result += line + "\n";
				// Remain word append into new line
				line = s;
			}
			// Append current word into current line
			else {
				line = temp;
			} 
		}
		
		// Append last line into result        
		result += line;
		
		// Remove first " " char
		return result.Substring(1,result.Length-1);
	}
	// Update is called once per frame
	void Update () {
		if (startcont > 205) {
			GetComponent<Renderer>().enabled = visible;
			GetComponent<Collider>().enabled = hasBody;
			//move ();
		}
		else
			GetComponent<Renderer>().enabled = false;
		if(startcont < 210)
			startcont++;
	}
}
