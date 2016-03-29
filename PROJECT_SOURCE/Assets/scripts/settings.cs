using UnityEngine;
using System.Collections;

public class settings : MonoBehaviour {

	Transform trans;
	bool set;
	GameObject mn;
	TextMesh tm;
	Vector3 xpos;
	void Start () {
		set = false;
		tm = GameObject.Find ("lname").GetComponent<TextMesh> ();
		mn = GameObject.Find ("menu");
		trans = mn.GetComponent<Transform> ();
		xpos = trans.position;
	}
	
    void OnMouseDown(){
		set = !set;
		if (set) {
						iTween.MoveTo (mn, iTween.Hash ("position", new Vector3 (20, 0, 0) + xpos, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 0.8f));
						tm.text = "";		
				} else {
						iTween.MoveTo (mn, iTween.Hash ("position", new Vector3 (-20, 0, 0) + xpos, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 0.8f));
			tm.text="Use Arrow/AD keys to navigate through levels";		
		}
		}
}
