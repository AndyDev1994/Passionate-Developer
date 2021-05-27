using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel2 : MonoBehaviour {

	public int sceneIndex2;
	void OnTriggerEnter(Collider other){
		//Compara se a Tag do objeto collidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Passportb")) {
			Application.LoadLevel (sceneIndex2);


		}	
	}
}