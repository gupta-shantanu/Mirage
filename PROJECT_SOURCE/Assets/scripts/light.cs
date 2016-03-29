using UnityEngine;
using System.Collections;

public class light : MonoBehaviour {
	private Light l;
	float i=1;
	// Use this for initialization
	void Start () {
		l = GetComponent<Light>();
		StartCoroutine("wait");
	}
	
	// Update is called once per frame
	void Update () {	
		wait ();
	}
	IEnumerator wait(){
		while (true) {
						l.intensity = l.intensity + i * 0.1f;
						if (l.intensity > 0.7) {
				i = -0.7f;
						}
						if (l.intensity < 0.1)
				i = 0.8f;
						yield return new WaitForSeconds (0.1f);
				}
	}
}
