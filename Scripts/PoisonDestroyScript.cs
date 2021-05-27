using UnityEngine;
using System.Collections;

public class PoisonDestroyScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Compara se a Tag do objeto collidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Player")) {
			//Elimina o GameObject da Cena.
			Destroy (gameObject);


		}
	}
}