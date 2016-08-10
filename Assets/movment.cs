using UnityEngine;
using System.Collections;

public class movment : MonoBehaviour {

	public Rigidbody2D phys;
	public int jumpSpeed = 10;
	public int moveSpeed = 10;
	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//jump ();
		//right ();
		//left ();
		up();
		right();
		left();
		down();
	}
			
/*	public void jump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			phys.velocity = new Vector2 (phys.velocity.x, jumpSpeed);
		}
	}
	public void right(){
		if (Input.GetKeyDown (KeyCode.D)) {
			phys.velocity = new Vector2 (moveSpeed, phys.velocity.y);
		}
	}

	public void left(){
		if (Input.GetKeyDown (KeyCode.A)) {
			phys.velocity = new Vector2 (moveSpeed * -1, phys.velocity.y);
		}
	}*/

	public void up(){
		if (Input.GetKeyDown (KeyCode.W)) {
			phys.AddForce (Vector2.up * moveSpeed, ForceMode2D.Impulse);
		}
	}

	public void right(){
		if (Input.GetKeyDown (KeyCode.D)) {
			phys.AddForce (Vector2.right * moveSpeed, ForceMode2D.Impulse);
		}
	}

	public void left(){
		if (Input.GetKeyDown (KeyCode.A)) {
			phys.AddForce (Vector2.left * moveSpeed, ForceMode2D.Impulse);
		}
	}

	public void down(){
		if (Input.GetKeyDown (KeyCode.S)) {
			phys.AddForce (Vector2.down * moveSpeed, ForceMode2D.Impulse);
		}
	}





}
	