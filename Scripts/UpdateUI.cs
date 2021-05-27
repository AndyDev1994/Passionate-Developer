using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UpdateUI : MonoBehaviour {
	public Text scoreUI;
	//public Text waterScore;
	//public Text grainScore;
	//public Text sunScore;
	//public GameObject portalTimer;
	//public Text totalPointsUI;
	//public Slider portaltimer;
	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
	//public RectTransform healthBar;

	public float maxtimer;
	public float timeout;
	// Imprime na tela a pontuação total e anula quaLquer alteração no score da fase seta ora zero o tempo restante


	void Start (){
	     
		//portaltimer.maxValue = maxtimer;
	
	
	
	}


	void Update () {
		if (GameManager.instancia.finished) {
			scoreUI.enabled = false;
			//waterScore.enabled = false;
			//grainScore.enabled = false;
			//sunScore.enabled = false;
			 //portalTimer.enabled = false;
			//totalPointsUI.enabled = true;
			//totalPointsUI.text = GameManager.instancia.points.ToString () + " Total Collected"; 
		
		// resetara o tempo restante
		//} else {
			//portalTimer. = "Time Left:"
			//+ ((int)(GameManager.instancia.time_left)).ToString ();
	}
		//maxtimer -= timeout * Time.deltaTime;
		//portaltimer.value = maxtimer;

		//if (maxtimer = 0) {
		
		     
		//}
	}



	//public void TakeDamage(int amount)
	//{
		//currentHealth -= amount;

		//if(currentHealth <= 0)
		//{
			//currentHealth = 0;

		//}        
	//}

	//void OnChangeHealth(int currentHealth)
	//{
		//healthBar.sizeDelta = new Vector2(currentHealth,
			//healthBar.sizeDelta.y);
	//}
}

