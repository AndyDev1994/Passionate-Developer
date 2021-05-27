using UnityEngine;
using System.Collections;

public class IA03 : MonoBehaviour {

	public Transform target;


	//Enumeradores
	private enum estadosInimigos3{
		Vagar,
		Seguir,
		Atacar
	}

	//Variavel que  vai guardar o estado atual
	private estadosInimigos3 estadoAtual;

	public Renderer rend;

	// Use this for initialization
	void Start () {
		//criar uma instancia de estados
		estadoAtual = new estadosInimigos3();

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
			estadoAtual = estadosInimigos3.Atacar;
		} else if (distancia >= 50) {
			estadoAtual = estadosInimigos3.Vagar;
		} else {
			estadoAtual = estadosInimigos3.Seguir;
		}

		//Fazer a checagem do estado atual e executar o que cada um vai fazer
		switch(estadoAtual){

		case estadosInimigos3.Vagar:

			rend.material.color = Color.blue;
			break;

		case estadosInimigos3.Seguir:

			Vector3 Dir1 = (target.position - transform.position).normalized;
			transform.position += Dir1 * Time.deltaTime * 15;
			transform.rotation = Quaternion.LookRotation (Dir1);
			rend.material.color = Color.yellow;
			break;

		case estadosInimigos3.Atacar:

			Vector3 Dir2 = (target.position - transform.position).normalized;
			transform.position += Dir2 * Time.deltaTime * 30;
			transform.rotation = Quaternion.LookRotation (Dir2);
			rend.material.color = Color.red;
			break;

		}
	}

}
