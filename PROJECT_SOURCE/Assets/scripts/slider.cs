using UnityEngine;
using System.Collections;

public class slider : MonoBehaviour {
	private float horizontal;
	private int min=1,max=10;
	public static int Level=1;
	private Vector3 pos;
	string[] msg;
	GameObject loc;
	TextMesh LevelName;
	void Start () {
		Texture2D pixel = (Texture2D) Resources.Load("pixel");
		iTween.CameraFadeAdd(pixel);
		iTween.CameraFadeFrom(1,0.9f);
		ApplicationModel.msg = new string[]{
			"1. Learn to Live.",
			"2. World Of Confusion.",
			"3. Fool me Twice...",
			"4. Crab's Dinner",
			"5. False Hopes",
			"6. Dumping grounds",
			"7. Lost Hope",
			"8. Doubting the Nature",
			"9. Exhaustion",
			"10. Walk, no more..."
		};
		//Debug.Log (PlayerPrefs.HasKey ("level"));


		ApplicationModel.muted = false;

		loc = GameObject.Find ("lock");
		LevelName=GameObject.Find ("lname").GetComponent<TextMesh>();
		checkLock();
		pos = gameObject.transform.position;
	}
	

	void Update () {
		if ((Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A)) && Level>min) {
			Level -= 1;
			slide();
		}
		else if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && Level<max){
			{

				Level += 1;
				slide ();

			}

	}
	}
	public static void load()
{
		ApplicationModel.currentLevel = Level;
		Application.LoadLevel ("level"+Level.ToString ());

		}
	void checkLock(){
		if (Level > ApplicationModel.savedLevel )
			loc.SetActive (true);
		else 
			loc.SetActive (false);
	}
	public void mute(){
		audio.mute = !audio.mute;
	}
	void slide(){
		if(!ApplicationModel.muted)
		audio.Play ();
		LevelName.text=ApplicationModel.msg[Level-1];
		checkLock();
		iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(-10.4f*(Level-1),0,0)+ pos, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", 0.8f));
	}
}


