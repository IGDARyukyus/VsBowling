﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCount : MonoBehaviour {

	private int FellPin = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetJudgeFall(){
		FellPin++;
	}

	public int GetJudgeFall (){
		return FellPin;
	}

	public void ResetJudgeFall(){
		FellPin = 0;
	}

}
