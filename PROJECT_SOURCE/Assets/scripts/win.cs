using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {
	private Light l;
	bool collided=false;
	void Start () {
		l = GameObject.Find ("floodLight").GetComponent<Light>();
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);

	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "player" && !collided && player.alive) {
				other.gameObject.SendMessage("pauseOnly",false);	
				SendMessage("WaitAndLoadNextScene");
			collided = true;
				}


	}
	IEnumerator WaitAndLoadNextScene(){
		//solveScene (ApplicationModel.currentLevel);
		l.intensity=0.5f;
		for (int i=0; i<10; i++) {
			l.intensity+=0.1f;
			yield return new WaitForSeconds (0.1f);
				}
		iTween.CameraFadeTo(1,.8f);
		yield return new WaitForSeconds (0.9f);
		if(PlayerPrefs.GetInt("level")<=ApplicationModel.currentLevel)
		PlayerPrefs.SetInt ("level",(ApplicationModel.currentLevel+1) );
		if(ApplicationModel.currentLevel==1)
			Application.LoadLevel("level2");
		else 
			Application.LoadLevel("levelEnd");
	}

}
