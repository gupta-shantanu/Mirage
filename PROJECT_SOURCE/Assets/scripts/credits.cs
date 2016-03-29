using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	[SerializeField]
	private float time;


	void Start () {
		iTween.MoveFrom(gameObject, iTween.Hash("position", new Vector3(-10,0,0)+transform.position, "isLocal", true, "easetype", iTween.EaseType.easeInOutQuad, "time", time));
	
		
		//iTween.MoveFrom (gameObject, iTween.Hash( "position", new Vector3(0,10,0) + gameObject.transform.position, "time", MyTime, "easetype", iTween.EaseType.easeInOutQuad) );
	
	}

	

}
