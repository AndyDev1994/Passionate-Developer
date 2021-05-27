using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VenenoScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){

		//Compara se a Tag do objetocollidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Poison")) {
			//Elimina o GameObject da Cena.
			Destroy (gameObject);
			// ativa o button no canvas e seta ele como true.
		
		}
   }
}