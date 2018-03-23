using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed;

	private Vector3 playerPos;

	void Start () 
	{
		playerPos = transform.position;
	}

	void Update () 
	{
		float x = transform.position.x + (Input.GetAxis("Horizontal")*paddleSpeed);
		playerPos = new Vector3(Mathf.Clamp(x,-8,8),transform.position.y,transform.position.z);
		transform.position = playerPos;
	}
}
