using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PrefabShooter : MonoBehaviour {
	public GameObject bulletPrefab;

	public GameObject spawBullet;


	 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Fire();
		}
	}


	void Fire()
	{
		var bullet = Instantiate(bulletPrefab, 
			spawBullet.transform.position,
			spawBullet.transform.rotation);

		bullet.GetComponent<Rigidbody>().velocity =
			bullet.transform.forward * 40;


		Destroy(bullet, 5.0f);
	}
}

