using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {
	GameObject t,plr;
	TextMesh tm;
	Transform trans;
	string[] msg;
	int[] dist;

	int i,min=-10;
	void Start () {
		t = GameObject.Find ("txt");
		trans = GameObject.Find ("player").GetComponent<Transform> ();
		tm = t.GetComponent<TextMesh> ();
		msg=new string[]{
			"I can move if you press Arrow keys........",
			"A-D keys does the same thing to me....",
			"I see a distant light.....",
			"My instinct tells me, oceans are only bright things at night!",
			"Aah! an obstacle... Spacebar/W/Up might help",
			"Nice...Now I should just head to the brightest way!",
			"My instinct tells me those moving creatures are my predators...",
			"I must avoid them....",
			"Strange objects all around....",
			"I can use these things...but I should be careful!",
			"There! I see the light again....but to reach there...",
			"......a long journey awaits"
		};
		dist=new int[]{-1,1,6,10,28,38,42,62,68,90,101};


	
	}
	

	void Update () {
		float x;
		x = trans.position.x;
		for(i=0;i<11;i++){
			if(dist[i]>(int)x)
				break;
		}
		min=(min>i)? min:i;
		tm.text = msg[min];
	}
}
