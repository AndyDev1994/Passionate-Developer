using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            var health = collision.gameObject.
				GetComponent<PlayerHealthBar>();
			    health.TakeDamage (1);
        }

        Destroy(gameObject);

    }
}
