using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAMaqEstados : MonoBehaviour {

	public Transform target;
	public Animator anim;
	public AudioSource attack;
	public AudioSource chasing;
	public int sceneindex4;



	//Enumeradores
	private enum estadosInimigos{
		Vagar,
		Seguir,
		Atacar
	}

	//Variavel que  vai guardar o estado atual
	private estadosInimigos estadoAtual;



	// Use this for initialization
	void Start () {
		//criar uma instancia de estados
		estadoAtual = new estadosInimigos();

	}
	
	// Update is called once per frame
	void Update () {
		Seguir ();
	}

	void Seguir(){
	
		//variavel para guardar a distancia do inimigo e player
		float distancia = Vector3.Distance(transform.position, target.position);

		//Controle dos casos possiveis
		if (distancia <= 1) {
			estadoAtual = estadosInimigos.Atacar;
			Application.LoadLevel (sceneindex4);
		} else if (distancia >= 50) {
			estadoAtual = estadosInimigos.Vagar;
		} else {
			estadoAtual = estadosInimigos.Seguir;
		}
	
		//Fazer a checagem do estado atual e executar o que cada um vai fazer
		switch(estadoAtual){

		case estadosInimigos.Vagar:


			break;

		case estadosInimigos.Seguir:

			Vector3 Dir = (target.position - transform.position).normalized;
			transform.position += Dir * Time.deltaTime * 8;
			transform.rotation = Quaternion.LookRotation (Dir);
			anim.SetBool ("walk", true);
			anim.SetBool ("attack", false);

			break;

		case estadosInimigos.Atacar:

			Vector3 Dir2 = (target.position - transform.position).normalized;
			transform.position += Dir2 * Time.deltaTime * 5;
			transform.rotation = Quaternion.LookRotation (Dir2);
			anim.SetBool ("walk", false);
			anim.SetBool ("attack", true);

	
			break;

		

		
		}
	
	
		   
	
	}




		
			
		
		


}
