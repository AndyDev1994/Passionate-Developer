using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {
	public int sceneIndex;
	public static int releasedLevelStaticb = 1;

	void Awake()
	{
		if (PlayerPrefs.HasKey ("Level")) {
			releasedLevelStaticb = PlayerPrefs.GetInt ("Level", releasedLevelStaticb);

		}
	}



	void OnTriggerEnter(Collider other){
		//Compara se a Tag do objeto collidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Passport")) {
			Application.LoadLevel (sceneIndex);

		
		}	
 }
}