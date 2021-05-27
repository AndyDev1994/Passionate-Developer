using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterAnimations : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("q")) {
		
			anim.Play ("punch");
		
			anim.SetBool ("IsGuard", false);
			anim.SetBool ("IsKicking", false);



		}
	


		if (Input.GetKeyUp ("q")) {
			anim.SetBool ("IsPunching", false);

		}
		if (Input.GetKeyDown ("e")) {

			anim.Play ("kick");

			anim.SetBool ("IsGuard", false);
			anim.SetBool ("IsPunching", false);
		


		}
	

		if (Input.GetKeyDown (KeyCode.Mouse1)) {

			anim.Play ("guard");

			anim.SetBool("IsKicking", false);
			anim.SetBool ("IsPunching", false);
		
		}
	
	}
}
