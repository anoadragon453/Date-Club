using UnityEngine;
using System.Collections;

public class ShowMore : MonoBehaviour {
	public GameObject otherButton;
	public static bool visible = true;
	public GameObject qs;
	public GameObject textbox1;
	public GameObject textbox2;
	public GameObject textbox3;
	public GameObject textbox4;
	public GameObject t1;
	public GameObject t2;
	public GameObject t3;
	public GameObject t4;
	//public 
	public static bool hasBody = true;


	// Use this for initialization
	int startcont = 0;
	void Start () {
	
	}

	public class Answer {
		
		public string answerText = "";
		public int score = 0;
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		public string getAnswer(){
			return answerText;
		}
	}
	
	public class Question {
		
		public string questionText = "ChangeMe";
		public string category = "PleaseChangeMe";
		public Answer answer1;
		public Answer answer2;
		public Answer answer3;
		public Answer answer4;
		
		public Question(){
		}
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		public string getQuestionText () {
			return questionText;
		}
		public Answer getAnswerText (int i) {
			if (i == 1)
				return answer1;
			else if (i == 2)
				return answer2;
			else if (i == 3)
				return answer3;
			else if (i == 4)
				return answer4;
			else
				return answer1;
		}
	}

	public static void setVisible(bool vis){
		visible = vis;
	}
	public static void setRigidBody(bool vis){
		hasBody = vis;
	}
	void OnMouseDown(){
		visible = false;
		sew.setVisible (false);
		sew.setRigidBody (false);
		hasBody = false;
		textbox1.GetComponent<changePos>().setPos(new Vector3(-9.1f, -1.0f,0.0f));
		textbox2.GetComponent<changePos>().setPos(new Vector3 (-9.1f, -2.5f, 0.0f));
		textbox3.GetComponent<changePos>().setPos(new Vector3(-4.9f, -1.0f,0.0f));
		textbox4.GetComponent<changePos>().setPos(new Vector3(-4.9f, -2.5f,0.0f));

		GameObject displayQuestionObject = GameObject.Find ("qq");
		DisplayQuestion displayQuestionScript = displayQuestionObject.GetComponent<DisplayQuestion> ();
		int kkk = displayQuestionScript.boxNumber;
		//Question questemp = (Question)qs.GetComponent<DisplayQuestion> ().questions[kkk];

		DisplayQuestion.Question qls = (DisplayQuestion.Question)qs.GetComponent<DisplayQuestion> ().questions[kkk];
		//Debug.Log("questemp: "+qls.getQuestionText());
		string swg = qls.getAnswerText(1).getAnswer();
		string swg2 = qls.getAnswerText (2).getAnswer ();
		string swg3 = qls.getAnswerText (3).getAnswer ();
		string swg4 = qls.getAnswerText (4).getAnswer ();



		t1.GetComponent<TextMesh>().text = ResolveTextSize( swg, 27);
		t2.GetComponent<TextMesh> ().text = ResolveTextSize( swg2, 27);
		t3.GetComponent<TextMesh> ().text = ResolveTextSize( swg3, 27);
		t4.GetComponent<TextMesh> ().text = ResolveTextSize( swg4, 27);
		//showButton = false;
	}

	// Taken from http://answers.unity3d.com/questions/190800/wrapping-a-textmesh-text.html
	// Wrap text by line height.
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
			renderer.enabled = visible;
			collider.enabled = hasBody;
			//move ();
		}
		else
			renderer.enabled = false;
		if(startcont < 210)
		startcont++;
	}
}
