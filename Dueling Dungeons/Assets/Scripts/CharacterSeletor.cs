using UnityEngine;
using System.Collections;

public class CharacterSeletor : MonoBehaviour {
	public Sprite[] characterSprite;
	public int playerNum;
	public int spriteSelected = 0;
	public GUIText readyText;
	public GUIText sideText;
	private GUIText ready;
	// Use this for initialization
	void Start () {
		SpriteRenderer[] charSprite = gameObject.GetComponents<SpriteRenderer>();
		foreach (SpriteRenderer sprites in charSprite) {
			sprites.sprite = characterSprite[spriteSelected];
		}
		ready = (GUIText)Instantiate (readyText, new Vector3(0,0,0), Quaternion.identity);

		ready.GetComponent<ObjectLabel>().target = gameObject.transform;
		ready.transform.parent = gameObject.transform;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("player"+playerNum+" up")) {
			if(spriteSelected == 0){
				spriteSelected = characterSprite.Length-1;
			}
			else{
				spriteSelected--;
			}

			print(spriteSelected);
		}
		
		else if (Input.GetKeyUp ("down")) {
			if(spriteSelected == characterSprite.Length-1){
				spriteSelected = 0;
			}
			else{
				spriteSelected++;
			}
			print(spriteSelected);
		}

		SpriteRenderer[] charSprite = gameObject.GetComponents<SpriteRenderer>();
		foreach (SpriteRenderer sprites in charSprite) {
			sprites.sprite = characterSprite[spriteSelected];
		}

	}

	public void setPlayerReady(bool isPlayerReady){
		if (isPlayerReady) {
			ready.text = "Ready";
		} 
		else {
			ready.text = "";
		}
	}
}
