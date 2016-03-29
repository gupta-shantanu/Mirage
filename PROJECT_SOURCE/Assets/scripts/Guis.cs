using UnityEngine;
using System.Collections;

public class Guis : MonoBehaviour {    
	public Rect windowRect = new Rect(20, 20, 430, 400);
	
	int counter = 0;
	
	string text = "ABCD";
	
	bool toggle = false;
	
	void OnGUI() {
		windowRect = GUI.Window(0, windowRect, drawWindow, "noobtuts.com");
	}
	
	void drawWindow(int windowID) {    
		// simple button
		if (GUI.Button(new Rect(50, 100, 100, 50), "Clicked: " + counter))
			counter = counter + 1;
		
		// simple label
		GUI.Label(new Rect(170, 100, 200, 35), "I love noobtuts.com");
		
		// box without any text
		GUI.Box(new Rect(50, 180, 150, 50), "");
		
		// box with text
		GUI.Box(new Rect(220, 180, 150, 50), "BoxText");
		
		// text field (always needs a string to save the text)
		text = GUI.TextField(new Rect(50, 240, 150, 50), text);
		
		// toggle
		toggle = GUI.Toggle(new Rect(50, 290, 150, 50), toggle, "Toggle Me");        
	}
}

