#pragma strict

var Pic : GameObject;
var sound : AudioClip;
var text : GameObject;



function Start () {
	Pic.SetActive(false);
	text.SetActive (false);

}

function Update () {
if(Input.GetKeyDown(KeyCode.C)) { 
Pic.SetActive(false);


}
}



 

function OnTriggerStay (col : Collider) {

 
        if(col.gameObject.tag == "attackArea") {
                      
                      text.SetActive (true);
        		 if(Input.GetKeyDown(KeyCode.R)) {
        		    text.SetActive (false);
 					Pic.SetActive(true);
 					
 					AudioSource.PlayClipAtPoint(sound, transform.position);
 					}	
 				
						
                    
        		}
		}
				         	
               function OnTriggerExit (col : Collider) {

               text.SetActive (false);




               }
