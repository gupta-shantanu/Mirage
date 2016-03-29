using UnityEngine;
using System.Collections;

public class replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		Application.LoadLevel ("level"+ApplicationModel.currentLevel);
	}
}
