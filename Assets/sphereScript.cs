using UnityEngine;
using System.Collections;

public class sphereScript : MonoBehaviour {
	Rigidbody rigidBody;
	public float speed;
	// Use this for initialization
	void Start () {

		rigidBody = GetComponent<Rigidbody> ();
		speed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidBody.AddForce (movement * speed);
	}

}
