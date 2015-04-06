using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour {
	public GameObject attack;
	public Sprite questionbutton;
	public Sprite answerbutton;
	public GameObject displayText;
	public GameObject repoman;
	public GameObject ansbutt;
	public string selectedAns;
	public GameObject t1;
	public GameObject t2;
	public GameObject t3;
	public GameObject t4;
	public ArrayList questions;
	bool up = false;
	double change =0;
	int cnt = 0;
	//SelectResponse test = new SelectResponse();
	bool move =false; 
	// Use this for initialization

	// --------------- Objects --------------- //
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
		public int getScore(){
			return score;
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
				return null;
		}
		
	}

	void Start () {
		questions = new ArrayList ();

		Question question1 = new Question ();
		question1 = CreateQuestion("Where do you work?","Job",CreateAnswer("I work at as a software engineer at Google.",5),CreateAnswer("Umm… I don’t really have a job.",-5),CreateAnswer("I work as a sewage cleaner.",-5),CreateAnswer("I work as a priest at the local church.",0));
		questions.Add (question1);
		
		Question question2 = new Question ();
		question2 = CreateQuestion("How is your sister doing?","Home",CreateAnswer("Oh, she is doing really well.",5),CreateAnswer("He's doing fine.",0),CreateAnswer("Um, is it okay if we don’t talk about that right now?.",-5),CreateAnswer("Uhh, I don’t have a sister…",-5));
		questions.Add (question2);
		
		Question question3 = CreateQuestion("How’s your relationship with your dad?","Home",CreateAnswer("We still keep in touch..",0),CreateAnswer("Oh we talk almost every day over the phone. He’s a great guy.",5),CreateAnswer("You shouldn’t be worrying about that. ",-5),CreateAnswer("I don’t think that’s any of your business.",-5));
		questions.Add (question3);
		
		Question question4 = CreateQuestion("Was that your friend I saw on Facebook? She seemed really smart.","Friends",CreateAnswer("You checked my Facebook? That’s kinda weird.",-5),CreateAnswer("Oh Stacy? Yeah, it’s incredible what she does.",5),CreateAnswer("Uh, I have a lot of friends there. I don’t really know most of them",0),CreateAnswer("You shouldn’t be stalking me on facebook.",-5));
		questions.Add (question4);
		
		Question question5 = CreateQuestion("How do crazy people go through the forest? They take the psycho path.","joke",CreateAnswer("Haha, that is so funny.",5),CreateAnswer("That’s hilarious! You are so funny.",5),CreateAnswer("I really like your sense of humor. ",5),CreateAnswer("OMG, I never thought of that. ",5));
		questions.Add (question5);
		
		Question question6 = CreateQuestion("How do you get holy water? Boil the hell out of it","joke",CreateAnswer("That is certainly not a good joke.",-5),CreateAnswer("I loved the way you make jokes.",5),CreateAnswer("Haha, you should be nominated for the American Comedian awards",-5),CreateAnswer("haha, I’ll probably try that next time.",5));
		questions.Add (question6);
		
		Question question7 = CreateQuestion("It's better to have lobsters on your piano than crabs on your organ.","joke",CreateAnswer("Was that a joke? ",-5),CreateAnswer("Do  I need  to laugh?",-5),CreateAnswer("That is really not an appropriate thing to say. ",-5),CreateAnswer("haha, I never had such idea. ",5));
		questions.Add (question7);
		
		Question question8 = CreateQuestion("So this guy with a premature ejaculation problem comes out of nowhere.","joke",CreateAnswer("I like that. That is funny.",5),CreateAnswer("haha, I like the way you think.",5),CreateAnswer("huh? I didn’t get that. ",-5),CreateAnswer("That is not a good joke.",-5));
		questions.Add (question8);
		
		Question question9 = CreateQuestion("What did one ocean say to the other ocean? Nothing, they just waved.","joke",CreateAnswer("Haha, that is so  funny!",5),CreateAnswer("Why would you say such thing? ",-5),CreateAnswer("That is not funny.",-5),CreateAnswer("You shouldn’t be saying that. ",-5));
		questions.Add (question9);
		Debug.Log ("Testing score" + question9.answer3.getScore ());
		
		Question question10 = CreateQuestion("You kill vegetarian vampires with a steak to the heart.","joke",CreateAnswer("You shouldn’t make fun of vegetarians.",-5),CreateAnswer("What are you trying to say? Can we talk about something else.",-5),CreateAnswer("It likely that you are not going to get a vegetarian woman.",-5),CreateAnswer("You better be careful when try to be funny. This is not funny.",-5));
		questions.Add (question10);
		
		Question question11 = CreateQuestion("The midget fortune teller who kills his customers is a small medium at large.","joke",CreateAnswer("Hmm, ok.",-5),CreateAnswer("What? I didn’t get that.",-5),CreateAnswer("That is the worst joke I've ever heard.  ",-5),CreateAnswer("Haha, nice one!",-5));
		questions.Add (question11);
		
		Question question12= CreateQuestion("A magician was walking down the street and turned into a grocery store.","joke",CreateAnswer("huh? I didn’t get that.",-5),CreateAnswer("What are you trying to say? Can we talk about something else.",-5),CreateAnswer("That is the worst joke I've ever heard.",-5),CreateAnswer("That is not a good joke.",-5));
		questions.Add (question12);
	}

	// --------------- Init Objects Methods! --------------- //
	
	Answer CreateAnswer (string answerString, int answerScore) {
		Answer answer = new Answer();
		answer.score = answerScore;
		answer.answerText = answerString;
		return answer;
	}
	
	Question CreateQuestion (string questionString, string questionCategory, Answer answerOne, Answer answerTwo, Answer answerThree, Answer answerFour) {
		Question question = new Question ();
		question.questionText = questionString;
		question.category = questionCategory;
		question.answer1 = answerOne;
		question.answer2 = answerTwo;
		question.answer3 = answerThree;
		question.answer4 = answerFour;
		return question;
	} 

	public int getScoreFromAnswerText (string inputAnswerText) {
		//Debug.Log(inputAnswerText);
		Debug.Log ("Questions Count: " + questions.Count);
		for (int i = 0; i<questions.Count; i++) {
			Question temp = (Question) questions[i];

			for (int j = 1;j<5;j++){
				Answer tempAns = (Answer) temp.getAnswerText(j);
				//Debug.Log("asdasdasddsa"+tempAns);
				string mahDick = ResolveTextSize( tempAns.answerText, 27);
				if (mahDick.Equals(inputAnswerText)){
					Debug.Log("I'm returning successfuly!");
					return tempAns.getScore();
				}
				
			}
		}
		Debug.Log("I'm returning unsuccessfuly!");
		return 0;
	}

	public bool getMove(){
		return move;
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
void OnCollisionEnter(Collision col){
		//Debug.Log (col.gameObject.name);
	
	
		bool notResponse = true;
		for (int i = 1; i <5; i++) {
			string nam = "response" + i;
			if (col.gameObject.name == nam)
				notResponse = false;
			nam = "ques" + i;
			if (col.gameObject.name == nam)
				notResponse = false;
		}
	
		if (notResponse && (col.gameObject.name == "dragQuestion(Clone)" || col.gameObject.name == "dragnddrop(Clone)")) {
			if (col.gameObject.name == "dragQuestion(Clone)" && this.name == "GirlResponse") {
				Debug.Log("I'm not gonna check score.");
				float k = repoman.GetComponent<ControlReputation> ().reputationLevel;
				repoman.GetComponent<ControlReputation> ().reputationLevel = k - 5;
			} else if (col.gameObject.name == "dragnddrop(Clone)" && this.name == "GirlResponse") {
				string anstxt = ""; 
				int ans = 0;
				//int score;
				//Debug.Log ("bout to check score");



				//Debug.Log("The score was "+score);

				if (selectedAns == "response1") {
					anstxt = t1.GetComponent<TextMesh> ().text;
				

				}
				if (selectedAns == "response2") {
					anstxt = t2.GetComponent<TextMesh> ().text;

				}				
				if (selectedAns == "response3") {
					anstxt = t3.GetComponent<TextMesh> ().text;

				}
				if (selectedAns == "response4") {
					anstxt = t4.GetComponent<TextMesh> ().text;

				}

				int score = getScoreFromAnswerText (anstxt);
				Debug.Log(anstxt);
				Debug.Log (score);
				float curr = repoman.GetComponent<ControlReputation> ().reputationLevel;
				if((curr +score*2.5) <55)
				repoman.GetComponent<ControlReputation> ().reputationLevel = curr + score*3;

				/*estionObject = GameObject.Find ("qq");
				//int r = displayText.GetComponent<DisplayQuestion>().boxNumber;
				//Debug.Log(anstxt);

				//int kkk = displayQuestionScript.boxNumber;
				//Question questemp = (Question)qs.GetComponent<DisplayQuestion> ().questions[kkk];
			//	Debug.Log(ans);
				//DisplayQuestion.Question qls = (DisplayQuestion.Question)displayText.GetComponent<DisplayQuestion> ().questions[kkk];
				//int score = q.getAnswerText(ans).getScore();
				///float curr = repoman.GetComponent<ControlReputation>().reputationLevel;
				//epoman.GetComponent<ControlReputation>().reputationLevel = curr+score;
*/
			
			}
		
		
		
		
		
		}
		Destroy (col.gameObject);
		move = true;
		makeNew ();
		int lol = (int)Random.Range (0, 12);
		while(lol == displayText.GetComponent<DisplayQuestion>().boxNumber){
			lol = (int)Random.Range (0, 12);
		}
		displayText.GetComponent<DisplayQuestion> ().boxNumber = lol;
		DisplayQuestion.Question ques1 = (DisplayQuestion.Question)displayText.GetComponent<DisplayQuestion> ().manQuestions [lol];
		string heh = ques1.getQuestionText ();
		displayText.GetComponent<TextMesh> ().text = ResolveTextSize (heh, 27);
	}
	 void makeNew(){
	
			GetComponent<SpriteRenderer> ().sprite = questionbutton;
	
		int pos = Random.Range (0, 3);
		if (pos == 0)
			transform.position = new Vector3 (15, 4.5f, 0);
		else if (pos == 1)
			transform.position = new Vector3 (15, 2.15f, 0);
		else {
			transform.position = new Vector3(15,0.2f,0);
		}
		change = 0;
		move = true;
		if (Input.GetMouseButtonUp (0))
			up = !up;

	}
	 
	
	// Update is called once per frame
	void Update () {

			
	}

}
