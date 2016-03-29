using UnityEngine;
using System.Collections;

public class mute : MonoBehaviour {
	GameObject noSound;
	AudioSource audi;
	// Use this for initialization
	void Start () {
		audi = GameObject.Find ("bsound").GetComponent<AudioSource> ();
		noSound = GameObject.Find ("noSound");
		if (ApplicationModel.muted)
			noSound.SetActive (true);
		else
			noSound.SetActive (false);
		audi.mute = ApplicationModel.muted;
	
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		ApplicationModel.muted = !ApplicationModel.muted;

		if (ApplicationModel.muted)
						noSound.SetActive (true);
				else
						noSound.SetActive (false);
		audi.mute = ApplicationModel.muted;
	}
}
