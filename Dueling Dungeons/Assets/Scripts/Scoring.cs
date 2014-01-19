using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject sessionRef = GameObject.Find ("SessionConfig(Clone)");
		SessionConfig sessionScript = sessionRef.GetComponent<SessionConfig> ();
		sessionScript.playerWins[0]++;
		Application.LoadLevel("Results");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
