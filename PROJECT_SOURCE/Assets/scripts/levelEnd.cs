using UnityEngine;
using System.Collections;

public class levelEnd : MonoBehaviour {
	[SerializeField]
	GameObject t,lname,text;
	void Start () {
		lname.SetActive (false);
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);
		iTween.CameraFadeFrom(1,0.9f);
		int[] hash = new int[]{5,5,2,1,3,0,2,1,3,4};
		int a = hash[ApplicationModel.currentLevel];
		for (int i=0; i<5; i++) {
						if(i!=a){
						GameObject g = GameObject.Find ("end"+i);
						g.SetActive (false);
			}
			if(a==4)
				text.SetActive (false);
				}


		iTween.MoveTo (t, iTween.Hash ("position", new Vector3 (-3.5f, -2f, -1f), "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 3f));
		SendMessage("WaitAndLoadNextScene",a);
	}
	IEnumerator WaitAndLoadNextScene(int a){
		yield return new WaitForSeconds (5f);
		iTween.CameraFadeFrom(1,0.9f);
		GameObject.Find ("end" + a).SetActive (false);
		text.SetActive (false);
		t.SetActive (false);
		lname.SetActive (true);
		lname.GetComponent<TextMesh> ().text = ApplicationModel.msg [ApplicationModel.currentLevel];
		yield return new WaitForSeconds (3f);
		iTween.CameraFadeTo(1,.8f);
		yield return new WaitForSeconds (0.9f);
		Application.LoadLevel("level"+(ApplicationModel.currentLevel+1));
	}

}
