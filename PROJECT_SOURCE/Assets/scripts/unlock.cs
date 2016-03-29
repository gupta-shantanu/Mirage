using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

	GameObject locked,unlocked;
	void Start () {
		locked = GameObject.Find ("locked");
		unlocked=GameObject.Find ("unlocked");
		if (!PlayerPrefs.HasKey ("level"))
			PlayerPrefs.SetInt ("level", 1);
		ApplicationModel.savedLevel =PlayerPrefs.GetInt ("level");
		if (ApplicationModel.savedLevel < 1 || ApplicationModel.savedLevel > 10)
			ApplicationModel.savedLevel = 1;

		if (ApplicationModel.locked) {
			locked.SetActive (true);
			unlocked.SetActive (false);
						
				} else {
			ApplicationModel.savedLevel = 10;
			locked.SetActive (false);
			unlocked.SetActive (true);
				}
		
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		if (ApplicationModel.locked) {
			ApplicationModel.locked=false;
			ApplicationModel.savedLevel = 10;
			locked.SetActive (false);
			unlocked.SetActive (true);
				} else {
			ApplicationModel.locked=true;
			if (!PlayerPrefs.HasKey("level"))
			    PlayerPrefs.SetInt ("level", 1);
			    ApplicationModel.savedLevel =PlayerPrefs.GetInt ("level");
			locked.SetActive (true);
			unlocked.SetActive (false);
				}
	}
}
