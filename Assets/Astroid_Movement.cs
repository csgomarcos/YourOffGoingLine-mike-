using UnityEngine;
using System.Collections;

public class Astroid_Movement : MonoBehaviour {

	public Rigidbody2D phys;

	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
		move ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void move(){
		phys.velocity = new Vector2 (Random.Range(-10, 10), Random.Range(-10, 10));
	
	}
}