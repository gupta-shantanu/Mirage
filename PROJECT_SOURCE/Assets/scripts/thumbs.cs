using UnityEngine;
using System.Collections;

public class thumbs : MonoBehaviour {
	private float horizontal;
	private int min,max;
	[SerializeField]
	int mylevel;
	// Use this for initialization
	void Start () {
		if(mylevel==1)
		iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(2.3f, 2.3f, 1f), "time", 0.5f, "easeType", iTween.EaseType.easeOutSine));
		
	}
	
	// Update is called once per frame
	void Update () {
		horizontal=Input.GetAxis("Horizontal");
		if (horizontal != 0) {


			if(slider.Level == mylevel){
				iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(2.3f, 2.3f, 1f), "time", 0.5f, "easeType", iTween.EaseType.easeOutSine));
			}
			else
				iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1.8f, 1.8f, 1f), "time", 0.5f, "easeType", iTween.EaseType.easeOutSine));
				}
		
	}
	void OnMouseDown(){

		if (mylevel > ApplicationModel.savedLevel || mylevel!=slider.Level)
						shake ();
		else
		slider.load ();
		}
	void shake(){
		iTween.PunchScale (gameObject, new Vector3 (0.3f, 0.3f), 0.5f);
	}

}




