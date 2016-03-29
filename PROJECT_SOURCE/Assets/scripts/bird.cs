using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {
	Rigidbody2D rb;
	Transform t;
	Vector3 scale;
	float initialPos;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		t = GetComponent<Transform> ();
		rb.velocity = new Vector2 (1, 0);
		scale = t.localScale;
		initialPos = t.position.x;
	
	}

	void Update () {
		if ((t.position.x-initialPos)> 8) {
						rb.velocity = new Vector2 (-1, 0);
						scale.x=-1;
						t.localScale=scale;
				}
		if ((t.position.x-initialPos) < -8) {
						rb.velocity = new Vector2 (1, 0);
						scale.x=1;
						t.localScale=scale;
				}

	
	}
}
