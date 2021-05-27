var Player : Transform;
var MoveSpeed : float = 4;
var MinDist =5;
var MaxDist = 10;
var anime : Animator;
var sceneIndex4 : int = 0;
var attack : AudioSource;
var follow : AudioSource;


function Start()
{

}

function Update ()
{
	//Moves towrd player
	transform.LookAt (Player);
	if(Vector3.Distance(transform.position,Player.position ) >= MinDist) {
	
		transform.position += transform.forward * MoveSpeed*Time.deltaTime;
		anime.SetBool("walk",true);
		anime.SetBool("attack",false);
		//GetComponent.<AudioSource>().Play(follow);
		
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
		{
				//Destroy(this.gameObject);
				Application.LoadLevel(sceneIndex4);
				anime.SetBool("walk",false);
		        anime.SetBool("attack",true);
		        //GetComponent.<AudioSource>().Play(attack);
		
		
		}
	}
}