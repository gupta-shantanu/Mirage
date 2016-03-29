using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	private Rigidbody2D rb;
	[SerializeField]
	private float speed;
	[SerializeField]
	private Transform[] groundPoints;
	[SerializeField]
	private float groundRadius;
	[SerializeField]
	private LayerMask whatsGround;
	private bool facingRight=true;
	[SerializeField]
	private float jumpForce;
	private bool isgrounded;
	private Animator anim;
	[SerializeField]
	public static bool paused,muted,alive;
	[SerializeField]
	private int currLvl;
	float horizontal;
	GameObject t;
	TextMesh tm;

	// Use this for initialization
	void Start () {
		ApplicationModel.currentLevel = currLvl;
		t = GameObject.Find ("txt");
		tm = t.GetComponent<TextMesh> ();
		muted = ApplicationModel.muted;
		paused = false;
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {

		isgrounded = isGrounded();
		if (!paused) {
						HandleInput ();
						HandleLayers ();
				}

		
	}
	//void Update () {

	//}

	private void HandleMovement(float horizontal)
	{
		if (rb.velocity.y < 0) {
						anim.SetBool ("land",true);
				}
		rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);
				
		anim.SetFloat ("speed", Mathf.Abs (horizontal));
	}

	private void Flip(float horizontal)
	{
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight=!facingRight;
			Vector3 scale=transform.localScale;
			scale.x*=-1;
			transform.localScale=scale;
				}

		}
	private void jump(){
		anim.SetTrigger ("jump");
		if(!ApplicationModel.muted)
		audio.Play ();
		rb.AddForce(new Vector2(0,jumpForce));
		isgrounded = false;
	}
	private void HandleInput()
	{
		if (Input.GetKeyDown(KeyCode.F))
			Screen.fullScreen = !Screen.fullScreen;
						
		if ((Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Space)) && isgrounded) {
				jump ();	
				}
		horizontal=Input.GetAxis("Horizontal");
		if (!paused) {
			HandleMovement (horizontal);
			Flip (horizontal);
		}

	}
	private bool isGrounded(){
		//if (rb.velocity.y <= 0) 
		foreach(Transform point in groundPoints)
			{
				Collider2D[] colliders=Physics2D.OverlapCircleAll(point.position,groundRadius,whatsGround);
				foreach(Collider2D i in colliders)
				{
					if(i.gameObject!=gameObject)
						return true;
				}

			}
		
		return false;
	}
	private void HandleLayers()
	{
				if (!isgrounded)
						anim.SetLayerWeight (1, 1);
				else {
				
				anim.SetLayerWeight (1, 0);
				anim.SetBool ("land",false);
		}
		}
	 void pause(){
		paused = !paused;
		rb.isKinematic = !rb.isKinematic;
		anim.enabled = !anim.enabled;
	}
	void pauseOnly(bool animation){
		paused = true;
		anim.enabled = animation;
		if (animation) {
						anim.SetLayerWeight (1, 0);
				}
				else
						rb.isKinematic = true;
	}


		
}
