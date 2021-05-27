using UnityEngine;
using System.Collections;

public class LoadScene1 : MonoBehaviour {
	public int sceneIndex = 0;

	public void Update ()
	{
		{
			if (Input.GetKeyDown (KeyCode.Escape)) {

				Application.LoadLevel (sceneIndex);
			}

		}


	}
}
