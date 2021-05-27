using UnityEngine;
using System.Collections;

public class MovmentController : MonoBehaviour {
	// variavel de velocidade do corpo rigido,Força do pulo
	public float speed ;
	public float forceJump;
	// variavel que do componente RigidBody(corpo rigido 3D)
	private Rigidbody rb;
	public  PowerUp script;
	private bool Jump; // quando o botão e presionada, sendo seu valor verdadeiro quando declarado
	private const float groundRayLenght = 1f; // tamanho da linha
	public float moverHorizontal, moverVertical;
	public AudioSource JumpSfx;
	public float duration = 5.0f;

	// Use this for initialization
	void Start () {
		/* declara a variavel do do Rigidbody na função Start e inciliza seu
        atraves do metodo Get (Pega o componente)*/
		rb = GetComponent<Rigidbody> ();
		script = GetComponent<PowerUp> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Chama uma variavel do tipo float e assina um eixo virtual horizontual a ele
		float h = Input.GetAxis ("Horizontal");
		// Mesma operação do float h mas usandoi o eixo vertical
		float v = Input.GetAxis ("Vertical");

		Jump = Input.GetButton ("Jump");
		// declara uma novo Vector3 que recebe os parametros das variaveis h e v, referente ao Vector3 move
		Vector3 move = new Vector3 (h, 0.0f, v);

	
		//Aplica um metodo de força a Rigidbody do objeto, de acordo com so parametros de sua velocidede,
		//vezes o Vector3 do objeto de acordo com Tempo real em segundos da maquina
		rb.AddForce (speed * move * Time.deltaTime);
	    
		//Se estiver nochão e o botão jump for pressionado

		if(Physics.Raycast(transform.position,-Vector3.up,groundRayLenght)&& Jump) 
			{
	
			rb.AddForce(new Vector3(0f, forceJump, 0f));
			JumpSfx.Play ();

		  }
			}
}
