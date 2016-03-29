using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ApplicationModel.locked = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
						Application.LoadLevel ("menu");
	
	}
}
