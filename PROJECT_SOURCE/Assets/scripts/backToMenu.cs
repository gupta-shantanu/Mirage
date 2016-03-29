using UnityEngine;
using System.Collections;

public class backToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		Application.LoadLevel ("menu");
	}
}
