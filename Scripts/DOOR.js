//var doorClip : AnimationClip;
var Key : GameObject;
private var Door = false;

public var sceneIndex : int = 0;

function Start () 
{

}

function Update () 
{
	if (Input.GetKeyDown(KeyCode.R) && Door == true && Key.active == false)
	{
	         Application.LoadLevel (sceneIndex);

	}
}

function OnTriggerEnter (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		Door = true;
	}
}

function OnTriggerExit (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		Door = false;
	}
}