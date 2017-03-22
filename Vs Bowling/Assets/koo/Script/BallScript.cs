using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	private float speed = 2.0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward) * speed,
		ForceMode.VelocityChange);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
