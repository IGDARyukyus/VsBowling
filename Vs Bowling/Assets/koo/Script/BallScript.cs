using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {
	private float speed = 25.0f;
	Slider m_slider;
	//Slider m2_slider;
	GameObject PowerUI;
	//GameObject AngleUI;
	int pushCount;
	// Use this for initialization
	void Start () {
		PowerUI = GameObject.Find("PowerUI");
		m_slider = PowerUI.GetComponent<Slider> ();
		//AngleUI = GameObject.Find ("AngleUI");
		//m2_slider = AngleUI.GetComponent<Slider>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) && this.transform.position.x > -3) {
			this.transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.D) && this.transform.position.x < 3){
			this.transform.position += new Vector3 (1, 0, 0);
		}
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
		}
		/*if (pushCount == 1) {
			m2_slider.value += 1 * Time.deltaTime;
		}
		if (m2_slider.value == 1) {
			m2_slider.value = 0;
		}
		if (pushCount == 2) {
			transform.Rotate(new Vector3(0, 90, 0)*(m2_slider.value -0.5);
		}*/
	}
}