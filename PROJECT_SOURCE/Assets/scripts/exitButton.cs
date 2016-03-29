using UnityEngine;
using System.Collections;

public class exitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		Application.Quit();
	}
}
