using UnityEngine;
using System.Collections;

public class ResultsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("return")) 
		{
			print("enter key was pressed");
			Application.LoadLevel("Main Screen");
		}
	}
}
