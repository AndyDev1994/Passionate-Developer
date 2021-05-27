var scare : GameObject;
var played = false;
var trig = false;

var scareSound: AudioClip;
////////Make sure its not visable and reset////////
function Start () {
	trig = false;

	}
/////When player enters trigger/////// set to true///////
function OnTriggerEnter (other : Collider) {
	trig = true;
}
//////Enable renderer and trigger sound and timer/////
function Update () {
	if (trig == true) {

		makehimscream ();
	}
}
//// timer ////
function removeovertime () {
	yield WaitForSeconds (3.0);

	Destroy(this.gameObject);
	
}
//// sound /////
function makehimscream () {
	if (!played) {
		played = true;
		GetComponent.<AudioSource>().PlayOneShot(scareSound);
	}
}

