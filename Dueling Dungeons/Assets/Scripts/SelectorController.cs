using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour {
	public GameObject[] characterSelectors;
	public Vector3[] selectorLocations;
	public GameObject session;
	public GameObject selector;
	private bool[] playersDone = {false, false,false,false};
	private int numPlayers = 1;
	private int playersReady = 0;
	// Use this for initialization
	void Start () {
		if (GameObject.Find ("SessionConfig(Clone)") == null) {
			Instantiate(session);		
		}
		GameObject playerStartData = GameObject.Find ("PlayerStart");
		if (playerStartData != null) {
			TrackPlayerInput playerIn = playerStartData.GetComponent<TrackPlayerInput> ();

			characterSelectors [playerIn.whoClickedStart-1] = (GameObject)Instantiate (selector, selectorLocations [playerIn.whoClickedStart-1], Quaternion.identity);
			characterSelectors[playerIn.whoClickedStart-1].GetComponent<CharacterSeletor>().playerNum = playerIn.whoClickedStart;
			Destroy (GameObject.Find ("PlayerStart"));
		}
		else{
			characterSelectors [0] = (GameObject)Instantiate (selector, selectorLocations [0], Quaternion.identity);
			characterSelectors[0].GetComponent<CharacterSeletor>().playerNum = 1;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("player1 start")) {
			print ("player 1");
			if(characterSelectors[0] == null){
				characterSelectors [0] = (GameObject)Instantiate (selector, selectorLocations [0], Quaternion.identity);
				characterSelectors[0].GetComponent<CharacterSeletor>().playerNum = 1;
				numPlayers++;
			}
			else if(!playersDone[0]){
				playersDone[0] = true;
				characterSelectors[0].GetComponent<CharacterSeletor>().setPlayerReady(true);
				playersReady++;
				print ("Player 1 Ready");
			}
			else if(numPlayers == playersReady){
				print ("Start Game");
				startGame();
			}
		}
		if (Input.GetButtonUp ("player2 start")) {
			print ("player 2");
			if(characterSelectors[1] == null){
				characterSelectors [1] = (GameObject)Instantiate (selector, selectorLocations [1], Quaternion.identity);
				characterSelectors[1].GetComponent<CharacterSeletor>().playerNum = 2;
				numPlayers++;
			}
			else if(!playersDone[1]){
				playersDone[1] = true;
				characterSelectors[1].GetComponent<CharacterSeletor>().setPlayerReady(true);
				playersReady++;
				print ("Player 2 Ready");
			}
			else if(numPlayers == playersReady){
				print ("Start Game");
				startGame();
			}
		}
		if (Input.GetButtonUp ("player3 start")) {
			print ("player 3");
			if(characterSelectors[2] == null){
				characterSelectors [2] = (GameObject)Instantiate (selector, selectorLocations [2], Quaternion.identity);
				characterSelectors[2].GetComponent<CharacterSeletor>().playerNum = 3;
				numPlayers++;
			}
			else if(!playersDone[2]){
				playersDone[2] = true;
				characterSelectors[2].GetComponent<CharacterSeletor>().setPlayerReady(true);
				playersReady++;
				print ("Player 3 Ready");
			}
			else if(numPlayers == playersReady){
				print ("Start Game");
				startGame();
			}
		}
		if (Input.GetButtonUp ("player4 start")) {
			print ("player 4");
			if(characterSelectors[3] == null){
				characterSelectors [3] = (GameObject)Instantiate (selector, selectorLocations [3], Quaternion.identity);
				characterSelectors[3].GetComponent<CharacterSeletor>().playerNum = 4;
				numPlayers++;
			}
			else if(!playersDone[3]){
				characterSelectors[3].GetComponent<CharacterSeletor>().setPlayerReady(true);
				playersDone[3] = true;
				playersReady++;
				print ("Player 4 Ready");
			}
			else if(numPlayers == playersReady){
				print ("Start Game");
				startGame();
			}
		}
	}
	
	void startGame(){
		//Get player data to use in the game
		//Application.LoadLevel("Level_1");
	}
}
