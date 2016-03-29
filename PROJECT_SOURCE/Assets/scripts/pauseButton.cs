using UnityEngine;
using System.Collections;

public class pauseButton : MonoBehaviour {

	// Use this for initialization
	GameObject plr,menu;
	Vector3 xpos;

	bool paused=false;

	void Start () {
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);
		iTween.CameraFadeFrom(1,0.9f);
		plr = GameObject.Find ("player");
		menu = GameObject.Find ("menu");
		xpos = menu.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			pauseEvent();

		}
	}
	void OnMouseDown(){
		pauseEvent ();
	}
	void pauseEvent(){
		plr.SendMessage("pause");
		paused = !paused;
		if(paused)
			iTween.MoveTo (menu, iTween.Hash ("position", new Vector3 (5, 0, 0) + xpos, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 0.8f));
		else
			iTween.MoveTo (menu, iTween.Hash ("position", new Vector3 (-5, 0, 0) + xpos, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 0.8f));
	}
}
