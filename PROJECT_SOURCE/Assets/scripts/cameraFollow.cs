using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	[SerializeField]
	private float xmin,xmax,ymin,ymax;
	Transform target;
	void Start () {
		target = GameObject.Find ("player").GetComponent<Transform>();
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (Mathf.Clamp (target.position.x, xmin, xmax), Mathf.Clamp (target.position.y, ymin, ymax), transform.position.z);
	
	}
}
