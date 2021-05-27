var Player: GameObject;
var scareSound: AudioClip;

function OnTriggerEnter(other : Collider)//Check if something has entered the trigger ( and declares this object in "other" )
{
	if(other.GetComponent.<Collider>().tag == Player.tag) //Checks if player is in trigger
	{
		GetComponent.<AudioSource>().PlayOneShot(scareSound);
		
	}
}