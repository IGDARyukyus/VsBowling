using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {
	private float speed = 5.0f;
	Slider m_slider;
	GameObject PowerUI;
	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward) * speed,
		ForceMode.VelocityChange);
		PowerUI = GameObject.Find("PowerUI");
		m_slider = PowerUI.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			m_slider.value += 1 * Time.deltaTime;
		}
		if (m_slider.value == 1) {
			m_slider.value = 0;
		}

	}
}