using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdonlyInstantietePrefabs : MonoBehaviour {
	public List<GameObject> prefabsBase;
	public float distanciaMax;
	public int  quantia;




	// Use this for initialization
	void Start () {
		Vector3 centro = transform.position;

		for (int i = 0; i < quantia; i++) {

			int indicealeatorio = Random.Range (0, prefabsBase.Count);

			GameObject prefabEscolhido = prefabsBase [indicealeatorio];

			Vector3 posicaoInstancia = new Vector3 ();

			posicaoInstancia.x = Random.Range ((centro.x - distanciaMax) , (centro.x + distanciaMax ));

			posicaoInstancia.z = centro.z;

			posicaoInstancia.y = Random.Range ((centro.y - distanciaMax) , (centro.y + distanciaMax ));


			Instantiate(prefabEscolhido, posicaoInstancia, Quaternion.identity);


		}



	}
	
	// Update is called once per frame
	void Update () {

	



	}
}
