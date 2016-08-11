using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public Text deathbox;
	public Text textbox;
	public void SetHealth(int health) {
		textbox.text = "Health: " + health;
	}
	public void DeathScreen (){
		deathbox.text = "GAME OVER";
	}
}
