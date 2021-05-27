using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA02 : MonoBehaviour {

	public Transform target;


	//Enumeradores
	private enum estadosInimigos2{
		Vagar,
		Seguir,
		Atacar
	}

	//Variavel que  vai guardar o estado atual
	private estadosInimigos2 estadoAtual;

	public Renderer rend;

	// Use this for initialization
	void Start () {
		//criar uma instancia de estados
		estadoAtual = new estadosInimigos2();

	}

	// Update is called once per frame
	void Update () {
		Seguir ();
	}

	void Seguir(){

		//variavel para guardar a distancia do inimigo e player
		float distancia = Vector3.Distance(transform.position, target.position);

		//Controle dos casos possiveis
		if (distancia <= 2) {
			estadoAtual = estadosInimigos2.Atacar;
		} else if (distancia >= 50) {
			estadoAtual = estadosInimigos2.Vagar;
		} else {
			estadoAtual = estadosInimigos2.Seguir;
		}

		//Fazer a checagem do estado atual e executar o que cada um vai fazer
		switch(estadoAtual){

		case estadosInimigos2.Vagar:

			rend.material.color = Color.blue;
			break;

		case estadosInimigos2.Seguir:

			Vector3 Dir = (target.position - transform.position).normalized;
			transform.position += Dir * Time.deltaTime * 10;
			transform.rotation = Quaternion.LookRotation (Dir);
			rend.material.color = Color.yellow;
			break;

		case estadosInimigos2.Atacar:

			Vector3 Dir2 = (target.position - transform.position).normalized;
			transform.position += Dir2 * Time.deltaTime * 25;
			transform.rotation = Quaternion.LookRotation (Dir2);
			rend.material.color = Color.red;
			break;

		}
	}

}
