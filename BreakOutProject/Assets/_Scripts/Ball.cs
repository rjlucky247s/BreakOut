using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f;

	private Rigidbody rb;
	private bool ballInMotion=false;
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1") && !ballInMotion) 
		{
			transform.parent = null;
			ballInMotion = true;
			rb.isKinematic = false;
			rb.AddForce (new Vector3 (ballInitialVelocity, ballInitialVelocity, 0));

		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Brick") 
		{
			Destroy (col.gameObject, 0.1f);
		}
	}
}
