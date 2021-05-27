#pragma strict


var sound : AudioClip;
var text : GameObject;
var text2 : GameObject;
var text3 : GameObject;
var Key : GameObject;


function Start () {
	
	text.SetActive (false);
	text2.SetActive (false);
	text3.SetActive (false);
}


function OnTriggerStay (col : Collider) {

 
        if(col.gameObject.tag == "attackArea") {
                      
                      text.SetActive (true);
                      text3.SetActive (true);
        		 if(Input.GetKeyDown(KeyCode.R)) {
        		    text2.SetActive (true);
 				
 					
 					AudioSource.PlayClipAtPoint(sound, transform.position);
 					}	
 				
						
                    
        		}
		}
				         	
               function OnTriggerExit (col : Collider) {

               text.SetActive (false);
               text2.SetActive (false);



               }


               function Update(){

                 if(Key.active == false){

                  text.SetActive (false);
                  text2.SetActive (false);



                 }


               }
