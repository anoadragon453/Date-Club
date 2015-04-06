using UnityEngine;
using System.Collections;

public class AutoType : MonoBehaviour {
	
	public float letterPause = 0.2f;
	public AudioClip sound;
	string message;
	public TextMesh textObject;
	int starts = 0;
	
	// Use this for initialization
	void Start () {
		message = textObject.text;
		textObject.text = "";
		StartCoroutine(TypeText ());
	}
	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			textObject.text += letter;
			if (sound)
				GetComponent<AudioSource>().PlayOneShot (sound);
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}      
	}
	void Update(){
		if (starts == 205) {
			message = textObject.text;
			textObject.text = "";
			StartCoroutine(TypeText ());
	
		}
		starts++;
	}
}