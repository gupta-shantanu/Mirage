using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public static int savedLevel;

	void Start () {

		if (PlayerPrefs.GetString ("level") == "")
						PlayerPrefs.SetString ("level", "1");
		savedLevel=int.Parse(PlayerPrefs.GetString ("level"));
	}

	void Update () {
	
	}
}
