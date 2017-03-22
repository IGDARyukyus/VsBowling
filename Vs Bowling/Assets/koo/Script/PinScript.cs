using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour {

	float PinX;
	float PinZ;
	bool FallPin;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		PinX = this.gameObject.transform.rotation.eulerAngles.x;
		PinZ = this.gameObject.transform.rotation.eulerAngles.z;
		if(60.0f < PinX && PinX < 90.0f || -60.0f > PinX && PinX > -90.0f ||
		   60.0f < PinZ && PinZ < 90.0f || -60.0f > PinZ && PinZ > -90.0f){
			FallPin = true;
		}
		print(FallPin);
		print (PinX);
		print (PinZ);
	}
}
