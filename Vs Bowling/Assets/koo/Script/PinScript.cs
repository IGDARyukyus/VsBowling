using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour {

	float PinX;
	bool FallPin;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		PinX = this.gameObject.transform.rotation.x;
		if(60.0f < PinX){
			FallPin = true;
		}
		print(FallPin);
	}
}
