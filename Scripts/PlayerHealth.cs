using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int  maxFallDistance = 0;//Distancia maxima do player ao cair
	
	// Update is called once per frame
	void Update () {
		//Retorna ao menu do game
		if (transform.position.y <= maxFallDistance)
		{
			Application.LoadLevel("Menu");
		}
	}
	}

