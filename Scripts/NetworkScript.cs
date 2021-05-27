using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class NetworkScript : NetworkBehaviour{

	public GameObject FirstPersonCharacter;
	public GameObject[] CharacterModel;

	public override void OnStartLocalPlayer (){


		GetComponent<FirstPersonController> ().enabled = true;
		FirstPersonCharacter.SetActive (true);


		foreach (GameObject go in CharacterModel) {
		
			go.SetActive (false);
		
		}
			
	}




}




