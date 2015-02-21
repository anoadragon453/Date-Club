using UnityEngine;
using System.Collections;

public class ShowInstructions : MonoBehaviour {

	public TextMesh textMeshToDisplay;

	// Use this for initialization
	void Start () {
		textMeshToDisplay.text = ResolveTextSize ("What is Dateclub?" +"\n"+"Date club is a strategy game that teaches a man how to have a successful date." +"\n"+"\n"+"Goal of the game?" +"\n"+"You are in the conversation with a woman on a date. Your goal is to save your date and make sure that she likes your responses and attitude. You have to answer appropriately, and in a such way that her interest does not end up as zero until the end of minute conversation." +"\n"+"\n"+"How to win Dateclub?"+"\n"+"To achieve the best result and win her heart you have to keep her happy during the two minute conversation. You have to use the mouse and select appropriate resoponse and ask questions from the panel below. To ask questions and resopond to her question, drag them to the questions and responses from the panel. From your responses and questions she will resopond. If you make her sad by a crazy question or response, she will lose some intereset in you. Her interest in you will increase when you be a interesting and a gentleman." +"\n"+"\n"+"How to win Dateclub?"+"\n"+"To win Dateclub you have to have her interest in you at least up to 75%. If it is lower than that she would not like you to see anymore."+"\n"+"\n"+"What if you win?"+"\n"+"If you win, you will be prompt to proceed to the next level which is the more harder stage. When finish all the levels, we are pretty sure you would be success in all of your future date."+"\n"+"\n"+"What happens if you lose?"+"\n"+"Don't be sad. Keep trying to make her happy and finish all the levels. When you will win this game entirely, you will be the ultimate playboy of real life.", 100);
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
