using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBar : MonoBehaviour {
	public const int maxHealth = 5;


	public int currentHealth = maxHealth;
	public RectTransform healthBar;

	public void TakeDamage(int amount)
	{        

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			currentHealth = 0;
			Destroy (this.gameObject);
		}        
	}

	void OnChangeHealth(int currentHealth)
	{
		healthBar.sizeDelta = new Vector2(currentHealth,
			healthBar.sizeDelta.y);
	}
}
