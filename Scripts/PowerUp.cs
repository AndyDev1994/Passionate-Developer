using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

public float multiplier = 0.1f;
public float duration = 5.0f;

	void OnTriggerEnter(Collider other){


		if (other.CompareTag ("Player")) {

			StartCoroutine (PowerUP (other));

		}

	}

	
		IEnumerator PowerUP(Collider player){

		 
		    MovmentController power = player.GetComponent<MovmentController> ();
		    power.forceJump  *= multiplier;

			yield return new WaitForSeconds (duration);

			power.forceJump /= multiplier;

		}
	
	
	
	
}
