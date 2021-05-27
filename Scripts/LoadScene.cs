using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
	{
		Application.LoadLevel (sceneIndex);
	}


}
