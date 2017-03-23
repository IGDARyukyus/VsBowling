using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Ball;
	public ScoreManager scoreManager;

	private GameObject NowBall;
	private int NowBowl;


	// Use this for initialization
	void Start () {
		GameObject newBall_1 = (GameObject)Instantiate (
			                     Ball, this.transform.position, Quaternion.identity);
		NowBowl = 0;

	}
	
	// Update is called once per frame
	void Update () {
		NowBall = GameObject.Find ("Ball(Clone)");

		if (scoreManager.GetBowling() != NowBowl) {
			Invoke("NextVisit",3);
		}

		Debug.Log ("GET:" + scoreManager.GetBowling () + " now:" + NowBowl);
	}

	void NextVisit(){
		Destroy (NowBall);

		GameObject newBall_2 = (GameObject)Instantiate (
			                     Ball, this.transform.position, Quaternion.identity);

		Debug.Log ("Miss...");
		CheckBowl ();
	}

	public void CheckBowl(){
		if (NowBowl == 0) {
			NowBowl = 1;
		} else if (NowBowl == 1) {
			NowBowl = 0;
		}
	}
}
