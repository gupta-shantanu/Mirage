using UnityEngine;
using System.Collections;

public class deadOnTouch : MonoBehaviour {

	Animator plrAnimator;
	AudioSource death;
	void Start () {
		plrAnimator=GameObject.Find ("player").GetComponent<Animator> ();
		death=GameObject.Find ("hell").GetComponent<AudioSource> ();
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);
	
	}
	
	void OnTriggerEnter2D(Collider2D plr){
	if(plr.gameObject.name=="player" && player.alive){
			player.alive=false;
			death.Play();
			plrAnimator.SetTrigger("dead");
			plr.gameObject.SendMessage("pauseOnly",true);
			SendMessage("WaitAndLoadNextScene");
		}



	}
	IEnumerator WaitAndLoadNextScene(){
		yield return new WaitForSeconds (2f);
		iTween.CameraFadeTo(1,.8f);
		yield return new WaitForSeconds (0.9f);
		if (ApplicationModel.currentLevel != 10)
						Application.LoadLevel ("level" + ApplicationModel.currentLevel);
				else {
			yield return new WaitForSeconds (3f);		
			Application.LoadLevel ("GameEnd");
						
				}
	}
}
