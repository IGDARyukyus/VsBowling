using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {
	private float speed = 25.0f;
	Slider m_slider;
	GameObject PowerUI;
	int pushCount;
	// Use this for initialization
	void Start () {
		PowerUI = GameObject.Find("PowerUI");
		m_slider = PowerUI.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			pushCount += 1;
		}
		if (pushCount == 1) {
			m_slider.value += 1 * Time.deltaTime;
		}
		if (m_slider.value == 1) {
			m_slider.value = 0;
		}
		if (pushCount == 2) {
			this.GetComponent<Rigidbody> ().AddForce (
				(transform.forward) * speed * m_slider.value,
				ForceMode.VelocityChange);
			pushCount = 0;
		}
	}
}