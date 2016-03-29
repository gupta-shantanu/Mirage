using UnityEngine;
using System.Collections;

public class collosionTrigger : MonoBehaviour {
	[SerializeField]
	private BoxCollider2D platform;
	private BoxCollider2D player;
	[SerializeField]
	private BoxCollider2D platformTrigger;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player").GetComponent<BoxCollider2D>();
		Physics2D.IgnoreCollision (platform, platformTrigger,true);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name=="player")
		   {
			Physics2D.IgnoreCollision (platform, player,true);
		}
		}
		void OnTriggerExit2D(Collider2D other)
		{
			if(other.gameObject.name=="player")
			   {
				Physics2D.IgnoreCollision (platform, player, false);
			}
			}

}
