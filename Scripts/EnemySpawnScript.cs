using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour {
	public GameObject prefab;
	void OnTriggerEnter (Collider other)
	{
		//Compara se a Tag do objeto collidido esta correspondente ao parametro da condiçao.
		if (other.CompareTag ("Spawn")) {

			GameObject newInstance = Instantiate (prefab, transform.position, transform.rotation) as GameObject;

		}
	}
}
