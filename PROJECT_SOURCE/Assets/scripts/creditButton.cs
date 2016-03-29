using UnityEngine;
using System.Collections;

public class creditButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseDown(){
		Application.LoadLevel ("credits");
	}
}
