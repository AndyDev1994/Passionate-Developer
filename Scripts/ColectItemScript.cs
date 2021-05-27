using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ColectItemScript : MonoBehaviour {
	public int points;
	public Transform coinEffect;

	public Text scoreUI;// aramzena no objeto de cena Text o placar do game
	// Use this for initialization

	void Start(){

		points = 0;
		scoreUI.text = "" + GameManager.instancia.points.ToString (); 

	}
	// Cria unma função que da um gatilho(trigger) ao colisor do GameObject.
		void OnTriggerEnter(Collider other){

		//Compara se a Tag do objeto collidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Fert")) {
			var effect = Instantiate (coinEffect, transform.position, transform.rotation);
			Destroy (effect.gameObject, 3);


			//Elimina o GameObject da Cena.
			Destroy (other.gameObject);
			// Incrementa a variavel points a cada collisão
			GameManager.instancia.points++;
			// Imprime na tela o score do jogador de acordo com a quantidade de Colletaveis pegos
			scoreUI.text = "" + GameManager.instancia.points.ToString (); 
		}

	}
}

