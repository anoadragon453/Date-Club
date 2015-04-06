using UnityEngine;
using System.Collections;

public class DisplayQuestion : MonoBehaviour {

	
	public int boxNumber;
	public TextMesh textMeshToDisplay;
	int startcont = 0;
	
	public  ArrayList questions;
	public  ArrayList manQuestions;
	public  ArrayList womanQuestions;
	
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

	public int getScoreFromAnswerText (string inputAnswerText) {
		for (int i = 0; i<questions.Count; i++) {
			Question temp = (Question) questions[i];
			for (int j = 1;j<5;j++){
				Answer tempAns = (Answer) temp.getAnswerText(j);
				if (tempAns.answerText.Equals(inputAnswerText)){
					return tempAns.getScore();
				}
				
			}
		}
		return 0;
	}
	
	// --------------- Init Objects Methods --------------- //
	
	Answer CreateAnswer (string answerString, int score) {
		Answer answer = new Answer();
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
	
	// --------------- Scripting Methods --------------- //
	
	// Use this for initialization
	void Start () {
		// Set up all the questions
		boxNumber = Random.Range (0, 12);
		questions = new ArrayList();
		manQuestions = new ArrayList ();
		womanQuestions = new ArrayList ();
		
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
		
		Question question10 = CreateQuestion("You kill vegetarian vampires with a steak to the heart.","joke",CreateAnswer("You shouldn’t make fun of vegetarians.",-5),CreateAnswer("What are you trying to say? Can we talk about something else.",-5),CreateAnswer("It likely that you are not going to get a vegetarian woman.",-5),CreateAnswer("You better be careful when try to be funny. This is not funny.",-5));
		questions.Add (question10);
		
		Question question11 = CreateQuestion("The midget fortune teller who kills his customers is a small medium at large.","joke",CreateAnswer("Hmm, ok.",-5),CreateAnswer("What? I didn’t get that.",-5),CreateAnswer("That is the worst joke I've ever heard.  ",-5),CreateAnswer("Haha, nice one!",-5));
		questions.Add (question11);
		
		Question question12= CreateQuestion("A magician was walking down the street and turned into a grocery store.","joke",CreateAnswer("huh? I didn’t get that.",-5),CreateAnswer("What are you trying to say? Can we talk about something else.",-5),CreateAnswer("That is the worst joke I've ever heard.",-5),CreateAnswer("That is not a good joke.",-5));
		questions.Add (question12);
		
		for (int i = 0; i < questions.Count; i++) {
			Question otherQuestionNew = (Question) questions[i];
			Debug.Log("Question #"+i+": "+otherQuestionNew.getQuestionText());
		}
		
		// --------------- Concise Method Execution --------------- //
		
		SortQuestions ();
		DisplayTextToPlayer ();
		Debug.Log ("box number"+boxNumber);
		/*for (int i = 0; i < newManQuestions.Count; i++) {
			Question temp = (Question) newManQuestions[i];
			Debug.Log (""+temp.getQuestionText());
		}*/
	}
	
	void SortQuestions () {
		for (int i = 0; i < questions.Count; i++) {
			Debug.Log(i);
			manQuestions.Add (questions[i]);
			//womanQuestions.Add (questions[i+1]);
		}
	}
	public void setBox(int i){
		boxNumber = i;
	}

	
	void DisplayTextToPlayer () {
		Question questionNew = (Question) manQuestions[boxNumber];
		Debug.Log ("Displaying text...");
		textMeshToDisplay.text = ResolveTextSize( questionNew.getQuestionText (), 27);
	}
	
	void removeQuestionFromQuestionBank (string questionText)
	{
		for (int i = 0; i < manQuestions.Count; i++) {
			Question otherQuestionNew = (Question) questions[i];
			string stringToCompare = otherQuestionNew.getQuestionText();
			if (stringToCompare.Equals (questionText)){
				manQuestions.Remove (questions[i]);
				Debug.Log("Removed Successfully");
				return;
			}
		}
	}
	public int getBox(){
		return boxNumber;
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
		if (startcont > 205)
			GetComponent<Renderer>().enabled = true;
		else
			GetComponent<Renderer>().enabled = false;
		startcont++;
	}
}