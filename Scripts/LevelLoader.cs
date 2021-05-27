﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public void LoadLevel(int sceneIndex){
	
		StartCoroutine(LoadAsyncronously(sceneIndex));
	   
	}
      
	IEnumerator LoadAsyncronously(int sceneIndex) 
	{

		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
	
		while (!operation.isDone);
		{

			Debug.Log (operation.progress);
			yield return null;
		}
	
	}


}
