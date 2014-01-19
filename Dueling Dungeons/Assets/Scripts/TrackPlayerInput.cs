using UnityEngine;
using System.Collections;

public class TrackPlayerInput : MonoBehaviour {
	public int whoClickedStart;
	private bool trackInput = true;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (trackInput) {
			if (Input.GetButtonUp ("player1 start")) {
				whoClickedStart = 1;
				print ("player 1");
				Application.LoadLevel ("Character_Select");
				trackInput = false;
			}
			if (Input.GetButtonUp ("player2 start")) {
				whoClickedStart = 2;
				print ("player 2");
				Application.LoadLevel ("Character_Select");
				trackInput = false;
			}
			if (Input.GetButtonUp ("player3 start")) {
				whoClickedStart = 3;
				print ("player 3");
				Application.LoadLevel ("Character_Select");
				trackInput = false;
			}
			if (Input.GetButtonUp ("player4 start")) {
				whoClickedStart = 4;
				print ("player 4");
				Application.LoadLevel ("Character_Select");
				trackInput = false;
			}
		}
	}
}
