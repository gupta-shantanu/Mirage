using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {
	void Start () {
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);
		iTween.CameraFadeFrom(1,0.9f);
		SendMessage("WaitAndLoadNextScene");
	
	}

	IEnumerator WaitAndLoadNextScene(){
		yield return new WaitForSeconds (2f);
		iTween.CameraFadeTo(1,.8f);
		yield return new WaitForSeconds (0.9f);
		Application.LoadLevel("start");
	}
}
