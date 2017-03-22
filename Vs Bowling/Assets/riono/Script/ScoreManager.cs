using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	// 何フレーム目か
	private int Flame;
	private bool Turn;
	// 何投目か
	private int bowling;

	// 1投のごとのスコア
	private int Score;
	// 合計得点
	private int TotalScore = 0;
	// 1フレームのスコア
	private int FlameScore = 0;

	public PinCount pinCount;

	public Text[] FirstScore = new Text[2];
	public Text[] SecondScore = new Text[2];
	public Text[] SumScore = new Text[2];


	void Start(){
		Score = -1;
		Flame = 0;
		Turn = true;
		bowling = 0;    // ボールスクリプトから受け取る？
	}

	void Update(){
		if (pinCount.GetJudgeFall() >= 1) {   // どれかのピンが倒されてから5秒後
			StartCoroutine (CulcScore ());
		}
		// ガーターの場合


		// 相手のターンが終了したら
		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("restart");
			Turn = true;
			bowling = 0;
		}
	}

	private IEnumerator CulcScore(){
		// スコアの計算と表示
		yield return new WaitForSeconds (5.0f);
		if (pinCount.GetJudgeFall () != 0) {
			JudgeScore ();
			DisplayScore ();
		}
	}
		
	// スコアの判断
	void JudgeScore(){
		// ピンを倒した時
		Score = pinCount.GetJudgeFall ();
		
		FlameScore += Score;
	
		if (Score == 10) {               // ストライクを出した時
			Turn = false; 
				// ストライクの処理
		} else if (Score >= 1) {        // 二投目に移行  条件内を投球カウントにする
			bowling += 1;			
		}
		pinCount.ResetJudgeFall ();
	}


	// スコアの表示
	void DisplayScore(){
		// 配列 デバッグログ
		if (Score == -1) {
			Debug.Log ("投球を開始してください。");

		}else if (bowling == 1) {
			Debug.Log ("Scoref:" + Score + "\nFlameScore:" + FlameScore + " bowling:" + bowling);
			FirstScore[Flame].text = Score.ToString();

		} else if (bowling == 2) {
			Debug.Log ("ScoreSecond:" + Score + "\nFlameScore:" + FlameScore + " bowling:" + bowling);
			TotalScore += FlameScore;

			SecondScore[Flame].GetComponent<Text> ().text = Score.ToString();
			SumScore[Flame].GetComponent<Text> ().text =TotalScore.ToString();

			FlameScore = 0;
			Turn = false;
			//Flame++;
		} 
		Score = -1;
	}
}