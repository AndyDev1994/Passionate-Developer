var TheKey : GameObject;
private var playerNextToKey = false;

function Update () 
{
 	if (Input.GetKeyDown(KeyCode.R) && playerNextToKey == true)
	{
	TheKey.SetActive(false);
	}
}

function OnTriggerEnter (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		playerNextToKey = true;
	}
}

function OnTriggerExit (theCollider : Collider)
{
	if (theCollider.tag == "Player")
	{
		playerNextToKey = false;
	}
}