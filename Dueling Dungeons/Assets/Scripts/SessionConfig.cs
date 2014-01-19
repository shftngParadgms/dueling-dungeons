using UnityEngine;
using System.Collections;

public class SessionConfig : MonoBehaviour {

	public bool[] playerActive;
	public int[] playerCharacter;
	public int[] playerSides;
	public int[] playerWins;
	public int[] sideWins;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
