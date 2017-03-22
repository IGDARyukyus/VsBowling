using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	private int Flame;
	private bool Turn;            
	private int bowling;

	private int Score;
	private int TotalScore;
	private int FlameScore = 0;


	void Start(){
		Score = 0;
		Flame = 1;
		Turn = true;
		bowling = 0;    // ボールスクリプトから受け取る
	}

	void Update(){
		if (Turn) {
			CalcScore ();
			DisplayScore ();
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("restart");
			Turn = true;
			bowling = 0;
		}
	}
		
	// スコアの計算
	void CalcScore(){
		// 判定を受ける
		// Score = GetJudgeCollapses ();
		if (Input.GetKeyDown (KeyCode.Space)) {
			Score += 1;
		
			FlameScore += Score;
	
			if (Score == 10) {               // ストライクを出した時
				Turn = false; 
				// ストライクの処理
		
			} else if (Score >= 1) {         // 二投目に移行
				bowling++;
			}	
		}
	}

	// スコアの表示
	void DisplayScore(){
		// 配列 デバッグログ
		if (bowling == 1) {
			Debug.Log ("Scoref:" + Score + "\nFlameScore:" + FlameScore + " bowling:" + bowling);
		} else if (bowling == 2) {
			Debug.Log ("ScoreSecond:" + Score + "\nFlameScore:" + FlameScore + " bowling:" + bowling);
			FlameScore = 0;
			Turn = false;
		} else {
			Debug.Log ("投球を開始してください。");
		}

		Score = 0;
	}
}
