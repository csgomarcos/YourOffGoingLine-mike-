using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public int shipHealth = 100;
	public int collisionDamage = 50;
	public HealthBar healthBar;

	public void OnCollisionEnter2D(Collision2D collider) {
		print ("hit object");
		TakeDamage (collisionDamage);
	}

	public void TakeDamage(int damage) {
		print ("take damaage");
		shipHealth = shipHealth - damage;
		healthBar.SetHealth (shipHealth);
		if (shipHealth <= 0) {
			healthBar.DeathScreen ();
		}
	}
}
