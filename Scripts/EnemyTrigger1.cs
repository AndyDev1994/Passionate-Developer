using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger1 : MonoBehaviour {

	public GameObject enemy;

	public GameObject trigger;


	void Start(){
	
		enemy.SetActive (false);
		trigger.SetActive (true);
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {

		if(other.gameObject.tag == "Player" ) {
		      
			enemy.SetActive (true);
			trigger.SetActive (false);





		}
		
	}
		


}
